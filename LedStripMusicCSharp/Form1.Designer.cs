
namespace LedStripMusicCSharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.disconnect_button = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.connection_status_label = new System.Windows.Forms.Label();
            this.ports_comboBox = new System.Windows.Forms.ComboBox();
            this.baund_rate_comboBox = new System.Windows.Forms.ComboBox();
            this.audio_progressBar = new System.Windows.Forms.ProgressBar();
            this.audio_devices_comboBox = new System.Windows.Forms.ComboBox();
            this.audio_timer = new System.Windows.Forms.Timer(this.components);
            this.audio_value_label = new System.Windows.Forms.Label();
            this.start_music_button = new System.Windows.Forms.Button();
            this.stop_music_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // disconnect_button
            // 
            this.disconnect_button.Enabled = false;
            this.disconnect_button.Location = new System.Drawing.Point(39, 57);
            this.disconnect_button.Name = "disconnect_button";
            this.disconnect_button.Size = new System.Drawing.Size(75, 23);
            this.disconnect_button.TabIndex = 0;
            this.disconnect_button.Text = "Disconnect";
            this.disconnect_button.UseVisualStyleBackColor = true;
            this.disconnect_button.Click += new System.EventHandler(this.disconnect_button_Click);
            // 
            // connect_button
            // 
            this.connect_button.Enabled = false;
            this.connect_button.Location = new System.Drawing.Point(120, 57);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 1;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // connection_status_label
            // 
            this.connection_status_label.AutoSize = true;
            this.connection_status_label.Location = new System.Drawing.Point(36, 105);
            this.connection_status_label.Name = "connection_status_label";
            this.connection_status_label.Size = new System.Drawing.Size(78, 13);
            this.connection_status_label.TabIndex = 2;
            this.connection_status_label.Text = "Not connected";
            // 
            // ports_comboBox
            // 
            this.ports_comboBox.FormattingEnabled = true;
            this.ports_comboBox.Location = new System.Drawing.Point(39, 13);
            this.ports_comboBox.Name = "ports_comboBox";
            this.ports_comboBox.Size = new System.Drawing.Size(121, 21);
            this.ports_comboBox.TabIndex = 3;
            this.ports_comboBox.SelectedIndexChanged += new System.EventHandler(this.ports_comboBox_SelectedIndexChanged);
            // 
            // baund_rate_comboBox
            // 
            this.baund_rate_comboBox.FormattingEnabled = true;
            this.baund_rate_comboBox.Items.AddRange(new object[] {
            "9600",
            "57600"});
            this.baund_rate_comboBox.Location = new System.Drawing.Point(166, 13);
            this.baund_rate_comboBox.Name = "baund_rate_comboBox";
            this.baund_rate_comboBox.Size = new System.Drawing.Size(121, 21);
            this.baund_rate_comboBox.TabIndex = 4;
            this.baund_rate_comboBox.SelectedIndexChanged += new System.EventHandler(this.bound_rate_comboBox_SelectedIndexChanged);
            // 
            // audio_progressBar
            // 
            this.audio_progressBar.Location = new System.Drawing.Point(40, 226);
            this.audio_progressBar.Name = "audio_progressBar";
            this.audio_progressBar.Size = new System.Drawing.Size(248, 23);
            this.audio_progressBar.TabIndex = 5;
            // 
            // audio_devices_comboBox
            // 
            this.audio_devices_comboBox.FormattingEnabled = true;
            this.audio_devices_comboBox.Location = new System.Drawing.Point(39, 142);
            this.audio_devices_comboBox.Name = "audio_devices_comboBox";
            this.audio_devices_comboBox.Size = new System.Drawing.Size(248, 21);
            this.audio_devices_comboBox.TabIndex = 6;
            this.audio_devices_comboBox.SelectedIndexChanged += new System.EventHandler(this.audio_devices_comboBox_SelectedIndexChanged);
            // 
            // audio_timer
            // 
            this.audio_timer.Tick += new System.EventHandler(this.audio_timer_Tick);
            // 
            // audio_value_label
            // 
            this.audio_value_label.AutoSize = true;
            this.audio_value_label.Location = new System.Drawing.Point(294, 236);
            this.audio_value_label.Name = "audio_value_label";
            this.audio_value_label.Size = new System.Drawing.Size(16, 13);
            this.audio_value_label.TabIndex = 9;
            this.audio_value_label.Text = "...";
            // 
            // start_music_button
            // 
            this.start_music_button.Location = new System.Drawing.Point(344, 139);
            this.start_music_button.Name = "start_music_button";
            this.start_music_button.Size = new System.Drawing.Size(75, 23);
            this.start_music_button.TabIndex = 11;
            this.start_music_button.Text = "start";
            this.start_music_button.UseVisualStyleBackColor = true;
            this.start_music_button.Click += new System.EventHandler(this.start_music_button_Click);
            // 
            // stop_music_button
            // 
            this.stop_music_button.Location = new System.Drawing.Point(442, 139);
            this.stop_music_button.Name = "stop_music_button";
            this.stop_music_button.Size = new System.Drawing.Size(75, 23);
            this.stop_music_button.TabIndex = 12;
            this.stop_music_button.Text = "stop";
            this.stop_music_button.UseVisualStyleBackColor = true;
            this.stop_music_button.Click += new System.EventHandler(this.stop_music_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stop_music_button);
            this.Controls.Add(this.start_music_button);
            this.Controls.Add(this.audio_value_label);
            this.Controls.Add(this.audio_devices_comboBox);
            this.Controls.Add(this.audio_progressBar);
            this.Controls.Add(this.baund_rate_comboBox);
            this.Controls.Add(this.ports_comboBox);
            this.Controls.Add(this.connection_status_label);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.disconnect_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button disconnect_button;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Label connection_status_label;
        private System.Windows.Forms.ComboBox ports_comboBox;
        private System.Windows.Forms.ComboBox baund_rate_comboBox;
        private System.Windows.Forms.ProgressBar audio_progressBar;
        private System.Windows.Forms.ComboBox audio_devices_comboBox;
        private System.Windows.Forms.Timer audio_timer;
        private System.Windows.Forms.Label audio_value_label;
        private System.Windows.Forms.Button start_music_button;
        private System.Windows.Forms.Button stop_music_button;
    }
}

