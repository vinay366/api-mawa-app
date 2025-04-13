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
            statusStrip = new StatusStrip();
            SystemStaus = new ToolStripStatusLabel();
            lblResults = new Label();
            httpVerbsSelection = new ComboBox();
            callDataTab = new TabControl();
            ButtonTab = new TabPage();
            OutputTab = new TabPage();
            apiresults = new TextBox();
            BodytextBox = new TextBox();
            statusStrip.SuspendLayout();
            callDataTab.SuspendLayout();
            ButtonTab.SuspendLayout();
            OutputTab.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.BackColor = Color.Transparent;
            formHeader.BorderStyle = BorderStyle.FixedSingle;
            formHeader.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formHeader.ForeColor = Color.OrangeRed;
            formHeader.Location = new Point(647, 79);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(303, 72);
            formHeader.TabIndex = 0;
            formHeader.Text = "API MAWA";
            // 
            // APILabel
            // 
            APILabel.AutoSize = true;
            APILabel.ForeColor = Color.DarkOrange;
            APILabel.Location = new Point(86, 201);
            APILabel.Name = "APILabel";
            APILabel.Size = new Size(88, 48);
            APILabel.TabIndex = 1;
            APILabel.Text = "API:";
            // 
            // InputURL
            // 
            InputURL.BackColor = Color.White;
            InputURL.BorderStyle = BorderStyle.FixedSingle;
            InputURL.Location = new Point(410, 202);
            InputURL.Name = "InputURL";
            InputURL.Size = new Size(862, 55);
            InputURL.TabIndex = 2;
            // 
            // callApi
            // 
            callApi.Location = new Point(1309, 202);
            callApi.Name = "callApi";
            callApi.Size = new Size(94, 55);
            callApi.TabIndex = 3;
            callApi.Text = "GO";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
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
            lblResults.Location = new Point(86, 282);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(124, 48);
            lblResults.TabIndex = 6;
            lblResults.Text = "Result";
            // 
            // httpVerbsSelection
            // 
            httpVerbsSelection.BackColor = Color.White;
            httpVerbsSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            httpVerbsSelection.FormattingEnabled = true;
            httpVerbsSelection.Items.AddRange(new object[] { "GET", "POST", "PUT", "PATCH", "UPDATE", "DELETE" });
            httpVerbsSelection.Location = new Point(183, 201);
            httpVerbsSelection.Name = "httpVerbsSelection";
            httpVerbsSelection.Size = new Size(185, 56);
            httpVerbsSelection.TabIndex = 7;
            // 
            // callDataTab
            // 
            callDataTab.Controls.Add(ButtonTab);
            callDataTab.Controls.Add(OutputTab);
            callDataTab.Location = new Point(86, 345);
            callDataTab.Name = "callDataTab";
            callDataTab.SelectedIndex = 0;
            callDataTab.Size = new Size(1340, 448);
            callDataTab.TabIndex = 8;
            // 
            // ButtonTab
            // 
            ButtonTab.Controls.Add(BodytextBox);
            ButtonTab.Location = new Point(4, 57);
            ButtonTab.Name = "ButtonTab";
            ButtonTab.Padding = new Padding(3);
            ButtonTab.Size = new Size(1332, 387);
            ButtonTab.TabIndex = 0;
            ButtonTab.Text = "Body";
            ButtonTab.UseVisualStyleBackColor = true;
            // 
            // OutputTab
            // 
            OutputTab.Controls.Add(apiresults);
            OutputTab.Location = new Point(4, 57);
            OutputTab.Name = "OutputTab";
            OutputTab.Padding = new Padding(3);
            OutputTab.Size = new Size(1332, 387);
            OutputTab.TabIndex = 1;
            OutputTab.Text = "Output";
            OutputTab.UseVisualStyleBackColor = true;
            // 
            // apiresults
            // 
            apiresults.BorderStyle = BorderStyle.FixedSingle;
            apiresults.Dock = DockStyle.Fill;
            apiresults.Location = new Point(3, 3);
            apiresults.Multiline = true;
            apiresults.Name = "apiresults";
            apiresults.ScrollBars = ScrollBars.Both;
            apiresults.Size = new Size(1326, 381);
            apiresults.TabIndex = 5;
            // 
            // BodytextBox
            // 
            BodytextBox.Dock = DockStyle.Fill;
            BodytextBox.Location = new Point(3, 3);
            BodytextBox.Multiline = true;
            BodytextBox.Name = "BodytextBox";
            BodytextBox.ScrollBars = ScrollBars.Both;
            BodytextBox.Size = new Size(1326, 381);
            BodytextBox.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(21F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1528, 859);
            Controls.Add(callDataTab);
            Controls.Add(httpVerbsSelection);
            Controls.Add(lblResults);
            Controls.Add(statusStrip);
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
            callDataTab.ResumeLayout(false);
            ButtonTab.ResumeLayout(false);
            ButtonTab.PerformLayout();
            OutputTab.ResumeLayout(false);
            OutputTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label APILabel;
        private TextBox InputURL;
        private Button callApi;
        private StatusStrip statusStrip;
        private Label lblResults;
        private ToolStripStatusLabel SystemStaus;
        private ComboBox httpVerbsSelection;
        private TabControl callDataTab;
        private TabPage ButtonTab;
        private TabPage OutputTab;
        private TextBox apiresults;
        private TextBox BodytextBox;
    }
}
