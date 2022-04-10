using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using NAudio.CoreAudioApi;
using NAudio.Wave;
using System;
using System.Threading;

namespace LedStripMusicCSharp
{
    public partial class Control : Form
    {
        SerialPort sp = new SerialPort();

        public Control()
        {
            InitializeComponent();

            foreach (var item in SerialPort.GetPortNames())
            {
                ports_comboBox.Items.Add(item);
            }
            
        }


        void getAudioDevices()
        {
            try
            {
                MMDeviceEnumerator deviceEnumerator = new MMDeviceEnumerator();
                var devices = deviceEnumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
                audio_devices_comboBox.Items.AddRange(devices.ToArray());
            }
            catch
            {
            }
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            try
            {
                sp.BaudRate = int.Parse(baund_rate_comboBox.SelectedItem.ToString());
                sp.PortName = ports_comboBox.Text;
                sp.Open();
                connect_button.Enabled = false;
                disconnect_button.Enabled = true;
                connection_status_label.Text = "Connected";
                getAudioDevices();
            }
            catch
            {
                connect_button.Enabled = true;
            }
        }

        private void disconnect_button_Click(object sender, EventArgs e)
        {
            try
            {
               
                
                disconnect_button.Enabled = false;
                connect_button.Enabled = true;
                connection_status_label.Text = "Disconnected";
                audio_devices_comboBox.Items.Clear();
                audio_devices_comboBox.Text = "";

                activeAduio = false;
                audio_timer.Enabled = false;
                activeAduio = false;
                audio_progressBar.Value = 0;
                audio_value_label.Text = "...";
               
                sp.Close();

            }
            catch (Exception)
            {
                disconnect_button.Enabled = true;
                throw;
            }
        }

        private void ports_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkPortsAndBaundRateComboBox();
        }

        private void bound_rate_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkPortsAndBaundRateComboBox();
            sp.BaudRate = int.Parse(baund_rate_comboBox.SelectedItem.ToString());
           
        }

        void checkPortsAndBaundRateComboBox()
        {
            if (ports_comboBox.SelectedItem != null && baund_rate_comboBox.SelectedItem != null)
            {
                connect_button.Enabled = true;
            }
        }

        bool activeAduio = false;
        MMDevice device;
        
        
        int audioValue2;

        
        private void audio_timer_Tick(object sender, EventArgs e)
        {
           
            if (activeAduio)
            {
                try
                {
                    int audioValue3 = (int)Math.Round(device.AudioMeterInformation.MasterPeakValue * 150);
                  
                    audio_progressBar.Value = audioValue3;
                    audio_value_label.Text = audioValue3.ToString();
                    sp.Write(audioValue3.ToString());
                }
                catch
                {
                   
                }
            }
            
        }

        private void audio_devices_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            device = (MMDevice)audio_devices_comboBox.SelectedItem;
        }

       
       
        

        

        private void start_music_button_Click(object sender, EventArgs e)
        {
            
            audio_timer.Enabled = true;
            activeAduio = true;
            
        }

        private void stop_music_button_Click(object sender, EventArgs e)
        {
            
            activeAduio = false;
            audio_timer.Enabled = false;
            activeAduio = false;
            
        }
    }
}
