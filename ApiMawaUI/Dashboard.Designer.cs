namespace ApiMawaUI
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            formHeader = new Label();
            APILabel = new Label();
            InputURL = new TextBox();
            callApi = new Button();
            apiresults = new TextBox();
            statusStrip = new StatusStrip();
            SystemStaus = new ToolStripStatusLabel();
            lblResults = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.BackColor = Color.Transparent;
            formHeader.BorderStyle = BorderStyle.FixedSingle;
            formHeader.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formHeader.ForeColor = Color.OrangeRed;
            formHeader.Location = new Point(643, 100);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(303, 72);
            formHeader.TabIndex = 0;
            formHeader.Text = "API MAWA";
            // 
            // APILabel
            // 
            APILabel.AutoSize = true;
            APILabel.ForeColor = Color.DarkOrange;
            APILabel.Location = new Point(234, 200);
            APILabel.Name = "APILabel";
            APILabel.Size = new Size(88, 48);
            APILabel.TabIndex = 1;
            APILabel.Text = "API:";
            // 
            // InputURL
            // 
            InputURL.BackColor = Color.White;
            InputURL.BorderStyle = BorderStyle.FixedSingle;
            InputURL.Location = new Point(328, 197);
            InputURL.Name = "InputURL";
            InputURL.Size = new Size(852, 55);
            InputURL.TabIndex = 2;
            // 
            // callApi
            // 
            callApi.Location = new Point(1201, 200);
            callApi.Name = "callApi";
            callApi.Size = new Size(94, 55);
            callApi.TabIndex = 3;
            callApi.Text = "GO";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // apiresults
            // 
            apiresults.BorderStyle = BorderStyle.FixedSingle;
            apiresults.Location = new Point(244, 367);
            apiresults.Multiline = true;
            apiresults.Name = "apiresults";
            apiresults.ScrollBars = ScrollBars.Both;
            apiresults.Size = new Size(1114, 394);
            apiresults.TabIndex = 4;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(24, 24);
            statusStrip.Items.AddRange(new ToolStripItem[] { SystemStaus });
            statusStrip.Location = new Point(0, 814);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1528, 45);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip1";
            // 
            // SystemStaus
            // 
            SystemStaus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SystemStaus.Name = "SystemStaus";
            SystemStaus.Size = new Size(92, 38);
            SystemStaus.Text = "Ready";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Location = new Point(244, 288);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(124, 48);
            lblResults.TabIndex = 6;
            lblResults.Text = "Result";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(21F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1528, 859);
            Controls.Add(lblResults);
            Controls.Add(statusStrip);
            Controls.Add(apiresults);
            Controls.Add(callApi);
            Controls.Add(InputURL);
            Controls.Add(APILabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Dashboard";
            Tag = "ApiMawa clone by postman";
            Text = "APIMawa";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label APILabel;
        private TextBox InputURL;
        private Button callApi;
        private TextBox apiresults;
        private StatusStrip statusStrip;
        private Label lblResults;
        private ToolStripStatusLabel SystemStaus;
    }
}
