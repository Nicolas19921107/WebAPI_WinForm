using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using WebAPI.Models;

namespace WinForm
{
    public partial class WinForm : Form
    {
        public WinForm()
        {
            InitializeComponent();
        }

        private void WinForm_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.NameOne = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.AgeOne = new System.Windows.Forms.TextBox();
            this.AgeTwo = new System.Windows.Forms.TextBox();
            this.NameTwo = new System.Windows.Forms.TextBox();
            this.AgeThr = new System.Windows.Forms.TextBox();
            this.NameThr = new System.Windows.Forms.TextBox();
            this.AgeFour = new System.Windows.Forms.TextBox();
            this.NameFour = new System.Windows.Forms.TextBox();
            this.ModelBindObjTitle = new System.Windows.Forms.Label();
            this.ModelBindingArrayTitle = new System.Windows.Forms.Label();
            this.ModelBindingNestedObjTitle = new System.Windows.Forms.Label();
            this.SimpleModelBindArrayTitle = new System.Windows.Forms.Label();
            this.ModelBindingArrayNestedObjTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Urlencoded = new System.Windows.Forms.Label();
            this.SimpleBindingHttpClientJSON = new System.Windows.Forms.TextBox();
            this.SimpleBindingTItle = new System.Windows.Forms.Label();
            this.SimpleBindingWebClientURL = new System.Windows.Forms.TextBox();
            this.SimpleBindingHttpClientURL = new System.Windows.Forms.TextBox();
            this.SimpleBindingRestCSharpURL = new System.Windows.Forms.TextBox();
            this.SimpleBindingWebApiContribURL = new System.Windows.Forms.TextBox();
            this.SimpleBindingWebClientJSON = new System.Windows.Forms.TextBox();
            this.SimpleBindingRestCSharpJSON = new System.Windows.Forms.TextBox();
            this.SimpleBindingWebApiContribJSON = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ModelBindingObjWebApiContribJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingObjRestCSharpJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingObjWebClientJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingObjWebApiContribURL = new System.Windows.Forms.TextBox();
            this.ModelBindingObjRestCSharpURL = new System.Windows.Forms.TextBox();
            this.ModelBindingObjHttpClientURL = new System.Windows.Forms.TextBox();
            this.ModelBindingObjHttpClientJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingObjWebClientURL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ModelBindingArrayWebApiContribJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayRestCSharpJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayWebClientJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayWebApiContribURL = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayRestCSharpURL = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayHttpClientURL = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayHttpClientJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayWebClientURL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ModelBindingNestedObjWebApiContribURL = new System.Windows.Forms.TextBox();
            this.ModelBindingNestedObjRestCSharpURL = new System.Windows.Forms.TextBox();
            this.ModelBindingNestedObjHttpClientURL = new System.Windows.Forms.TextBox();
            this.ModelBindingNestedObjWebClientURL = new System.Windows.Forms.TextBox();
            this.ModelBindingNestedObjWebApiContribJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingNestedObjRestCSharpJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingNestedObjHttpClientJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingNestedObjWebClientJSON = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ModelBindingArrayNestedObjWebApiContribJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayNestedObjRestCSharpJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayNestedObjHttpClientJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayNestedObjWebClientJSON = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayNestedObjWebApiContribURL = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayNestedObjRestCSharpURL = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayNestedObjHttpClientURL = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayNestedObjWebClientURL = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.SimpleModelBindArrayWebApiContribJSON = new System.Windows.Forms.TextBox();
            this.SimpleModelBindArrayRestCSharpJSON = new System.Windows.Forms.TextBox();
            this.SimpleModelBindArrayWebClientJSON = new System.Windows.Forms.TextBox();
            this.SimpleModelBindArrayWebApiContribURL = new System.Windows.Forms.TextBox();
            this.SimpleModelBindArrayRestCSharpURL = new System.Windows.Forms.TextBox();
            this.SimpleModelBindArrayHttpClientURL = new System.Windows.Forms.TextBox();
            this.SimpleModelBindArrayHttpClientJSON = new System.Windows.Forms.TextBox();
            this.SimpleModelBindArrayWebClientURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(844, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(353, 90);
            this.button1.TabIndex = 1;
            this.button1.Text = "送出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameOne
            // 
            this.NameOne.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameOne.Location = new System.Drawing.Point(104, 23);
            this.NameOne.Multiline = true;
            this.NameOne.Name = "NameOne";
            this.NameOne.Size = new System.Drawing.Size(179, 38);
            this.NameOne.TabIndex = 13;
            this.NameOne.TextChanged += new System.EventHandler(this.NameOne_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.LightBlue;
            this.NameLabel.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameLabel.Location = new System.Drawing.Point(12, 23);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(75, 37);
            this.NameLabel.TabIndex = 14;
            this.NameLabel.Text = "姓名";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.BackColor = System.Drawing.Color.LightBlue;
            this.AgeLabel.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeLabel.Location = new System.Drawing.Point(12, 76);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(75, 37);
            this.AgeLabel.TabIndex = 15;
            this.AgeLabel.Text = "年齡";
            // 
            // AgeOne
            // 
            this.AgeOne.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeOne.Location = new System.Drawing.Point(104, 75);
            this.AgeOne.Multiline = true;
            this.AgeOne.Name = "AgeOne";
            this.AgeOne.Size = new System.Drawing.Size(179, 38);
            this.AgeOne.TabIndex = 16;
            // 
            // AgeTwo
            // 
            this.AgeTwo.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeTwo.Location = new System.Drawing.Point(289, 75);
            this.AgeTwo.Multiline = true;
            this.AgeTwo.Name = "AgeTwo";
            this.AgeTwo.Size = new System.Drawing.Size(179, 38);
            this.AgeTwo.TabIndex = 18;
            // 
            // NameTwo
            // 
            this.NameTwo.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameTwo.Location = new System.Drawing.Point(289, 23);
            this.NameTwo.Multiline = true;
            this.NameTwo.Name = "NameTwo";
            this.NameTwo.Size = new System.Drawing.Size(179, 38);
            this.NameTwo.TabIndex = 17;
            // 
            // AgeThr
            // 
            this.AgeThr.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeThr.Location = new System.Drawing.Point(474, 75);
            this.AgeThr.Multiline = true;
            this.AgeThr.Name = "AgeThr";
            this.AgeThr.Size = new System.Drawing.Size(179, 38);
            this.AgeThr.TabIndex = 20;
            // 
            // NameThr
            // 
            this.NameThr.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameThr.Location = new System.Drawing.Point(474, 23);
            this.NameThr.Multiline = true;
            this.NameThr.Name = "NameThr";
            this.NameThr.Size = new System.Drawing.Size(179, 38);
            this.NameThr.TabIndex = 19;
            // 
            // AgeFour
            // 
            this.AgeFour.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AgeFour.Location = new System.Drawing.Point(659, 74);
            this.AgeFour.Multiline = true;
            this.AgeFour.Name = "AgeFour";
            this.AgeFour.Size = new System.Drawing.Size(179, 38);
            this.AgeFour.TabIndex = 22;
            // 
            // NameFour
            // 
            this.NameFour.Font = new System.Drawing.Font("細明體-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.NameFour.Location = new System.Drawing.Point(659, 22);
            this.NameFour.Multiline = true;
            this.NameFour.Name = "NameFour";
            this.NameFour.Size = new System.Drawing.Size(179, 38);
            this.NameFour.TabIndex = 21;
            // 
            // ModelBindObjTitle
            // 
            this.ModelBindObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindObjTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindObjTitle.Location = new System.Drawing.Point(12, 365);
            this.ModelBindObjTitle.Name = "ModelBindObjTitle";
            this.ModelBindObjTitle.Size = new System.Drawing.Size(185, 50);
            this.ModelBindObjTitle.TabIndex = 24;
            this.ModelBindObjTitle.Text = "ModelBindingObj( HttpClient )";
            this.ModelBindObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayTitle
            // 
            this.ModelBindingArrayTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingArrayTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayTitle.Location = new System.Drawing.Point(829, 137);
            this.ModelBindingArrayTitle.Name = "ModelBindingArrayTitle";
            this.ModelBindingArrayTitle.Size = new System.Drawing.Size(185, 48);
            this.ModelBindingArrayTitle.TabIndex = 26;
            this.ModelBindingArrayTitle.Text = "ModelBindingArray( HttpClient )";
            this.ModelBindingArrayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingNestedObjTitle
            // 
            this.ModelBindingNestedObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingNestedObjTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjTitle.Location = new System.Drawing.Point(827, 365);
            this.ModelBindingNestedObjTitle.Name = "ModelBindingNestedObjTitle";
            this.ModelBindingNestedObjTitle.Size = new System.Drawing.Size(185, 49);
            this.ModelBindingNestedObjTitle.TabIndex = 28;
            this.ModelBindingNestedObjTitle.Text = "ModelBindingNestedObj( HttpClient )";
            this.ModelBindingNestedObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleModelBindArrayTitle
            // 
            this.SimpleModelBindArrayTitle.BackColor = System.Drawing.Color.Orange;
            this.SimpleModelBindArrayTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindArrayTitle.Location = new System.Drawing.Point(10, 589);
            this.SimpleModelBindArrayTitle.Name = "SimpleModelBindArrayTitle";
            this.SimpleModelBindArrayTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SimpleModelBindArrayTitle.Size = new System.Drawing.Size(185, 50);
            this.SimpleModelBindArrayTitle.TabIndex = 30;
            this.SimpleModelBindArrayTitle.Text = "SimpleModelBindArray( HttpClient )";
            this.SimpleModelBindArrayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayNestedObjTitle
            // 
            this.ModelBindingArrayNestedObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingArrayNestedObjTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjTitle.Location = new System.Drawing.Point(826, 592);
            this.ModelBindingArrayNestedObjTitle.Name = "ModelBindingArrayNestedObjTitle";
            this.ModelBindingArrayNestedObjTitle.Size = new System.Drawing.Size(188, 49);
            this.ModelBindingArrayNestedObjTitle.TabIndex = 32;
            this.ModelBindingArrayNestedObjTitle.Text = "ModelBindingArrayNestedObj( HttpClient )";
            this.ModelBindingArrayNestedObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(514, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 669);
            this.label1.TabIndex = 40;
            this.label1.Text = "JSON";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Urlencoded
            // 
            this.Urlencoded.BackColor = System.Drawing.Color.SkyBlue;
            this.Urlencoded.Enabled = false;
            this.Urlencoded.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Urlencoded.Location = new System.Drawing.Point(201, 137);
            this.Urlencoded.Name = "Urlencoded";
            this.Urlencoded.Size = new System.Drawing.Size(119, 670);
            this.Urlencoded.TabIndex = 39;
            this.Urlencoded.Text = "Urlencoded";
            this.Urlencoded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleBindingHttpClientJSON
            // 
            this.SimpleBindingHttpClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingHttpClientJSON.Location = new System.Drawing.Point(641, 136);
            this.SimpleBindingHttpClientJSON.Multiline = true;
            this.SimpleBindingHttpClientJSON.Name = "SimpleBindingHttpClientJSON";
            this.SimpleBindingHttpClientJSON.ReadOnly = true;
            this.SimpleBindingHttpClientJSON.Size = new System.Drawing.Size(182, 49);
            this.SimpleBindingHttpClientJSON.TabIndex = 38;
            this.SimpleBindingHttpClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingTItle
            // 
            this.SimpleBindingTItle.BackColor = System.Drawing.Color.Orange;
            this.SimpleBindingTItle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingTItle.Location = new System.Drawing.Point(16, 137);
            this.SimpleBindingTItle.Name = "SimpleBindingTItle";
            this.SimpleBindingTItle.Size = new System.Drawing.Size(181, 50);
            this.SimpleBindingTItle.TabIndex = 37;
            this.SimpleBindingTItle.Text = "SimpleBinding( HttpClient )";
            this.SimpleBindingTItle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleBindingWebClientURL
            // 
            this.SimpleBindingWebClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingWebClientURL.Location = new System.Drawing.Point(328, 191);
            this.SimpleBindingWebClientURL.Multiline = true;
            this.SimpleBindingWebClientURL.Name = "SimpleBindingWebClientURL";
            this.SimpleBindingWebClientURL.ReadOnly = true;
            this.SimpleBindingWebClientURL.Size = new System.Drawing.Size(182, 50);
            this.SimpleBindingWebClientURL.TabIndex = 36;
            this.SimpleBindingWebClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingHttpClientURL
            // 
            this.SimpleBindingHttpClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingHttpClientURL.Location = new System.Drawing.Point(328, 136);
            this.SimpleBindingHttpClientURL.Multiline = true;
            this.SimpleBindingHttpClientURL.Name = "SimpleBindingHttpClientURL";
            this.SimpleBindingHttpClientURL.ReadOnly = true;
            this.SimpleBindingHttpClientURL.Size = new System.Drawing.Size(182, 50);
            this.SimpleBindingHttpClientURL.TabIndex = 57;
            this.SimpleBindingHttpClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingRestCSharpURL
            // 
            this.SimpleBindingRestCSharpURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingRestCSharpURL.Location = new System.Drawing.Point(328, 245);
            this.SimpleBindingRestCSharpURL.Multiline = true;
            this.SimpleBindingRestCSharpURL.Name = "SimpleBindingRestCSharpURL";
            this.SimpleBindingRestCSharpURL.ReadOnly = true;
            this.SimpleBindingRestCSharpURL.Size = new System.Drawing.Size(182, 50);
            this.SimpleBindingRestCSharpURL.TabIndex = 58;
            this.SimpleBindingRestCSharpURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingWebApiContribURL
            // 
            this.SimpleBindingWebApiContribURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingWebApiContribURL.Location = new System.Drawing.Point(328, 299);
            this.SimpleBindingWebApiContribURL.Multiline = true;
            this.SimpleBindingWebApiContribURL.Name = "SimpleBindingWebApiContribURL";
            this.SimpleBindingWebApiContribURL.ReadOnly = true;
            this.SimpleBindingWebApiContribURL.Size = new System.Drawing.Size(182, 50);
            this.SimpleBindingWebApiContribURL.TabIndex = 59;
            this.SimpleBindingWebApiContribURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingWebClientJSON
            // 
            this.SimpleBindingWebClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingWebClientJSON.Location = new System.Drawing.Point(641, 189);
            this.SimpleBindingWebClientJSON.Multiline = true;
            this.SimpleBindingWebClientJSON.Name = "SimpleBindingWebClientJSON";
            this.SimpleBindingWebClientJSON.ReadOnly = true;
            this.SimpleBindingWebClientJSON.Size = new System.Drawing.Size(182, 49);
            this.SimpleBindingWebClientJSON.TabIndex = 60;
            this.SimpleBindingWebClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingRestCSharpJSON
            // 
            this.SimpleBindingRestCSharpJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingRestCSharpJSON.Location = new System.Drawing.Point(641, 245);
            this.SimpleBindingRestCSharpJSON.Multiline = true;
            this.SimpleBindingRestCSharpJSON.Name = "SimpleBindingRestCSharpJSON";
            this.SimpleBindingRestCSharpJSON.ReadOnly = true;
            this.SimpleBindingRestCSharpJSON.Size = new System.Drawing.Size(182, 49);
            this.SimpleBindingRestCSharpJSON.TabIndex = 61;
            this.SimpleBindingRestCSharpJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleBindingWebApiContribJSON
            // 
            this.SimpleBindingWebApiContribJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleBindingWebApiContribJSON.Location = new System.Drawing.Point(641, 299);
            this.SimpleBindingWebApiContribJSON.Multiline = true;
            this.SimpleBindingWebApiContribJSON.Name = "SimpleBindingWebApiContribJSON";
            this.SimpleBindingWebApiContribJSON.ReadOnly = true;
            this.SimpleBindingWebApiContribJSON.Size = new System.Drawing.Size(182, 49);
            this.SimpleBindingWebApiContribJSON.TabIndex = 62;
            this.SimpleBindingWebApiContribJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Orange;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 50);
            this.label2.TabIndex = 63;
            this.label2.Text = "SimpleBinding( WebClient )";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Orange;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 50);
            this.label9.TabIndex = 64;
            this.label9.Text = "SimpleBinding( RestCSharp  )";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Orange;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 300);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 50);
            this.label10.TabIndex = 65;
            this.label10.Text = "SimpleBinding(  WebApiContrib  )";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Orange;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(185, 50);
            this.label11.TabIndex = 66;
            this.label11.Text = "ModelBindingObj( WebClient )";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Orange;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 476);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 50);
            this.label12.TabIndex = 67;
            this.label12.Text = "ModelBindingObj( RestCSharp )";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Orange;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 529);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(185, 50);
            this.label13.TabIndex = 68;
            this.label13.Text = "ModelBindingObj( WebApiContrib )";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingObjWebApiContribJSON
            // 
            this.ModelBindingObjWebApiContribJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjWebApiContribJSON.Location = new System.Drawing.Point(639, 528);
            this.ModelBindingObjWebApiContribJSON.Multiline = true;
            this.ModelBindingObjWebApiContribJSON.Name = "ModelBindingObjWebApiContribJSON";
            this.ModelBindingObjWebApiContribJSON.ReadOnly = true;
            this.ModelBindingObjWebApiContribJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingObjWebApiContribJSON.TabIndex = 76;
            this.ModelBindingObjWebApiContribJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjRestCSharpJSON
            // 
            this.ModelBindingObjRestCSharpJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjRestCSharpJSON.Location = new System.Drawing.Point(639, 474);
            this.ModelBindingObjRestCSharpJSON.Multiline = true;
            this.ModelBindingObjRestCSharpJSON.Name = "ModelBindingObjRestCSharpJSON";
            this.ModelBindingObjRestCSharpJSON.ReadOnly = true;
            this.ModelBindingObjRestCSharpJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingObjRestCSharpJSON.TabIndex = 75;
            this.ModelBindingObjRestCSharpJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjWebClientJSON
            // 
            this.ModelBindingObjWebClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjWebClientJSON.Location = new System.Drawing.Point(639, 418);
            this.ModelBindingObjWebClientJSON.Multiline = true;
            this.ModelBindingObjWebClientJSON.Name = "ModelBindingObjWebClientJSON";
            this.ModelBindingObjWebClientJSON.ReadOnly = true;
            this.ModelBindingObjWebClientJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingObjWebClientJSON.TabIndex = 74;
            this.ModelBindingObjWebClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjWebApiContribURL
            // 
            this.ModelBindingObjWebApiContribURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjWebApiContribURL.Location = new System.Drawing.Point(326, 528);
            this.ModelBindingObjWebApiContribURL.Multiline = true;
            this.ModelBindingObjWebApiContribURL.Name = "ModelBindingObjWebApiContribURL";
            this.ModelBindingObjWebApiContribURL.ReadOnly = true;
            this.ModelBindingObjWebApiContribURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingObjWebApiContribURL.TabIndex = 73;
            this.ModelBindingObjWebApiContribURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjRestCSharpURL
            // 
            this.ModelBindingObjRestCSharpURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjRestCSharpURL.Location = new System.Drawing.Point(326, 474);
            this.ModelBindingObjRestCSharpURL.Multiline = true;
            this.ModelBindingObjRestCSharpURL.Name = "ModelBindingObjRestCSharpURL";
            this.ModelBindingObjRestCSharpURL.ReadOnly = true;
            this.ModelBindingObjRestCSharpURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingObjRestCSharpURL.TabIndex = 72;
            this.ModelBindingObjRestCSharpURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjHttpClientURL
            // 
            this.ModelBindingObjHttpClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjHttpClientURL.Location = new System.Drawing.Point(326, 365);
            this.ModelBindingObjHttpClientURL.Multiline = true;
            this.ModelBindingObjHttpClientURL.Name = "ModelBindingObjHttpClientURL";
            this.ModelBindingObjHttpClientURL.ReadOnly = true;
            this.ModelBindingObjHttpClientURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingObjHttpClientURL.TabIndex = 71;
            this.ModelBindingObjHttpClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjHttpClientJSON
            // 
            this.ModelBindingObjHttpClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjHttpClientJSON.Location = new System.Drawing.Point(639, 365);
            this.ModelBindingObjHttpClientJSON.Multiline = true;
            this.ModelBindingObjHttpClientJSON.Name = "ModelBindingObjHttpClientJSON";
            this.ModelBindingObjHttpClientJSON.ReadOnly = true;
            this.ModelBindingObjHttpClientJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingObjHttpClientJSON.TabIndex = 70;
            this.ModelBindingObjHttpClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingObjWebClientURL
            // 
            this.ModelBindingObjWebClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingObjWebClientURL.Location = new System.Drawing.Point(326, 420);
            this.ModelBindingObjWebClientURL.Multiline = true;
            this.ModelBindingObjWebClientURL.Name = "ModelBindingObjWebClientURL";
            this.ModelBindingObjWebClientURL.ReadOnly = true;
            this.ModelBindingObjWebClientURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingObjWebClientURL.TabIndex = 69;
            this.ModelBindingObjWebClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(1331, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 669);
            this.label3.TabIndex = 78;
            this.label3.Text = "JSON";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(1020, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 670);
            this.label4.TabIndex = 77;
            this.label4.Text = "Urlencoded";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Orange;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(829, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 48);
            this.label5.TabIndex = 79;
            this.label5.Text = "ModelBindingArray( WebClient )";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Orange;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(829, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 48);
            this.label6.TabIndex = 80;
            this.label6.Text = "ModelBindingArray( RestCSharp )";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Orange;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(829, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 48);
            this.label7.TabIndex = 81;
            this.label7.Text = "ModelBindingArray( WebApiContrib )";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayWebApiContribJSON
            // 
            this.ModelBindingArrayWebApiContribJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayWebApiContribJSON.Location = new System.Drawing.Point(1458, 299);
            this.ModelBindingArrayWebApiContribJSON.Multiline = true;
            this.ModelBindingArrayWebApiContribJSON.Name = "ModelBindingArrayWebApiContribJSON";
            this.ModelBindingArrayWebApiContribJSON.ReadOnly = true;
            this.ModelBindingArrayWebApiContribJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingArrayWebApiContribJSON.TabIndex = 89;
            this.ModelBindingArrayWebApiContribJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayRestCSharpJSON
            // 
            this.ModelBindingArrayRestCSharpJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayRestCSharpJSON.Location = new System.Drawing.Point(1458, 245);
            this.ModelBindingArrayRestCSharpJSON.Multiline = true;
            this.ModelBindingArrayRestCSharpJSON.Name = "ModelBindingArrayRestCSharpJSON";
            this.ModelBindingArrayRestCSharpJSON.ReadOnly = true;
            this.ModelBindingArrayRestCSharpJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingArrayRestCSharpJSON.TabIndex = 88;
            this.ModelBindingArrayRestCSharpJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayWebClientJSON
            // 
            this.ModelBindingArrayWebClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayWebClientJSON.Location = new System.Drawing.Point(1458, 189);
            this.ModelBindingArrayWebClientJSON.Multiline = true;
            this.ModelBindingArrayWebClientJSON.Name = "ModelBindingArrayWebClientJSON";
            this.ModelBindingArrayWebClientJSON.ReadOnly = true;
            this.ModelBindingArrayWebClientJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingArrayWebClientJSON.TabIndex = 87;
            this.ModelBindingArrayWebClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayWebApiContribURL
            // 
            this.ModelBindingArrayWebApiContribURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayWebApiContribURL.Location = new System.Drawing.Point(1145, 299);
            this.ModelBindingArrayWebApiContribURL.Multiline = true;
            this.ModelBindingArrayWebApiContribURL.Name = "ModelBindingArrayWebApiContribURL";
            this.ModelBindingArrayWebApiContribURL.ReadOnly = true;
            this.ModelBindingArrayWebApiContribURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayWebApiContribURL.TabIndex = 86;
            this.ModelBindingArrayWebApiContribURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayRestCSharpURL
            // 
            this.ModelBindingArrayRestCSharpURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayRestCSharpURL.Location = new System.Drawing.Point(1145, 245);
            this.ModelBindingArrayRestCSharpURL.Multiline = true;
            this.ModelBindingArrayRestCSharpURL.Name = "ModelBindingArrayRestCSharpURL";
            this.ModelBindingArrayRestCSharpURL.ReadOnly = true;
            this.ModelBindingArrayRestCSharpURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayRestCSharpURL.TabIndex = 85;
            this.ModelBindingArrayRestCSharpURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayHttpClientURL
            // 
            this.ModelBindingArrayHttpClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayHttpClientURL.Location = new System.Drawing.Point(1145, 136);
            this.ModelBindingArrayHttpClientURL.Multiline = true;
            this.ModelBindingArrayHttpClientURL.Name = "ModelBindingArrayHttpClientURL";
            this.ModelBindingArrayHttpClientURL.ReadOnly = true;
            this.ModelBindingArrayHttpClientURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayHttpClientURL.TabIndex = 84;
            this.ModelBindingArrayHttpClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayHttpClientJSON
            // 
            this.ModelBindingArrayHttpClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayHttpClientJSON.Location = new System.Drawing.Point(1458, 136);
            this.ModelBindingArrayHttpClientJSON.Multiline = true;
            this.ModelBindingArrayHttpClientJSON.Name = "ModelBindingArrayHttpClientJSON";
            this.ModelBindingArrayHttpClientJSON.ReadOnly = true;
            this.ModelBindingArrayHttpClientJSON.Size = new System.Drawing.Size(182, 49);
            this.ModelBindingArrayHttpClientJSON.TabIndex = 83;
            this.ModelBindingArrayHttpClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayWebClientURL
            // 
            this.ModelBindingArrayWebClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayWebClientURL.Location = new System.Drawing.Point(1145, 191);
            this.ModelBindingArrayWebClientURL.Multiline = true;
            this.ModelBindingArrayWebClientURL.Name = "ModelBindingArrayWebClientURL";
            this.ModelBindingArrayWebClientURL.ReadOnly = true;
            this.ModelBindingArrayWebClientURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayWebClientURL.TabIndex = 82;
            this.ModelBindingArrayWebClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Orange;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(827, 418);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 49);
            this.label8.TabIndex = 90;
            this.label8.Text = "ModelBindingNestedObj( WebClient )";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Orange;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(827, 474);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 49);
            this.label14.TabIndex = 91;
            this.label14.Text = "ModelBindingNestedObj( RestCSharp )";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Orange;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(827, 529);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 49);
            this.label15.TabIndex = 92;
            this.label15.Text = "ModelBindingNestedObj( WebApiContrib )";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingNestedObjWebApiContribURL
            // 
            this.ModelBindingNestedObjWebApiContribURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjWebApiContribURL.Location = new System.Drawing.Point(1143, 527);
            this.ModelBindingNestedObjWebApiContribURL.Multiline = true;
            this.ModelBindingNestedObjWebApiContribURL.Name = "ModelBindingNestedObjWebApiContribURL";
            this.ModelBindingNestedObjWebApiContribURL.ReadOnly = true;
            this.ModelBindingNestedObjWebApiContribURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingNestedObjWebApiContribURL.TabIndex = 96;
            this.ModelBindingNestedObjWebApiContribURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingNestedObjRestCSharpURL
            // 
            this.ModelBindingNestedObjRestCSharpURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjRestCSharpURL.Location = new System.Drawing.Point(1143, 473);
            this.ModelBindingNestedObjRestCSharpURL.Multiline = true;
            this.ModelBindingNestedObjRestCSharpURL.Name = "ModelBindingNestedObjRestCSharpURL";
            this.ModelBindingNestedObjRestCSharpURL.ReadOnly = true;
            this.ModelBindingNestedObjRestCSharpURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingNestedObjRestCSharpURL.TabIndex = 95;
            this.ModelBindingNestedObjRestCSharpURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingNestedObjHttpClientURL
            // 
            this.ModelBindingNestedObjHttpClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjHttpClientURL.Location = new System.Drawing.Point(1143, 364);
            this.ModelBindingNestedObjHttpClientURL.Multiline = true;
            this.ModelBindingNestedObjHttpClientURL.Name = "ModelBindingNestedObjHttpClientURL";
            this.ModelBindingNestedObjHttpClientURL.ReadOnly = true;
            this.ModelBindingNestedObjHttpClientURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingNestedObjHttpClientURL.TabIndex = 94;
            this.ModelBindingNestedObjHttpClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingNestedObjWebClientURL
            // 
            this.ModelBindingNestedObjWebClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjWebClientURL.Location = new System.Drawing.Point(1143, 419);
            this.ModelBindingNestedObjWebClientURL.Multiline = true;
            this.ModelBindingNestedObjWebClientURL.Name = "ModelBindingNestedObjWebClientURL";
            this.ModelBindingNestedObjWebClientURL.ReadOnly = true;
            this.ModelBindingNestedObjWebClientURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingNestedObjWebClientURL.TabIndex = 93;
            this.ModelBindingNestedObjWebClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingNestedObjWebApiContribJSON
            // 
            this.ModelBindingNestedObjWebApiContribJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjWebApiContribJSON.Location = new System.Drawing.Point(1456, 527);
            this.ModelBindingNestedObjWebApiContribJSON.Multiline = true;
            this.ModelBindingNestedObjWebApiContribJSON.Name = "ModelBindingNestedObjWebApiContribJSON";
            this.ModelBindingNestedObjWebApiContribJSON.ReadOnly = true;
            this.ModelBindingNestedObjWebApiContribJSON.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingNestedObjWebApiContribJSON.TabIndex = 100;
            this.ModelBindingNestedObjWebApiContribJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingNestedObjRestCSharpJSON
            // 
            this.ModelBindingNestedObjRestCSharpJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjRestCSharpJSON.Location = new System.Drawing.Point(1456, 473);
            this.ModelBindingNestedObjRestCSharpJSON.Multiline = true;
            this.ModelBindingNestedObjRestCSharpJSON.Name = "ModelBindingNestedObjRestCSharpJSON";
            this.ModelBindingNestedObjRestCSharpJSON.ReadOnly = true;
            this.ModelBindingNestedObjRestCSharpJSON.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingNestedObjRestCSharpJSON.TabIndex = 99;
            this.ModelBindingNestedObjRestCSharpJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingNestedObjHttpClientJSON
            // 
            this.ModelBindingNestedObjHttpClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjHttpClientJSON.Location = new System.Drawing.Point(1456, 364);
            this.ModelBindingNestedObjHttpClientJSON.Multiline = true;
            this.ModelBindingNestedObjHttpClientJSON.Name = "ModelBindingNestedObjHttpClientJSON";
            this.ModelBindingNestedObjHttpClientJSON.ReadOnly = true;
            this.ModelBindingNestedObjHttpClientJSON.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingNestedObjHttpClientJSON.TabIndex = 98;
            this.ModelBindingNestedObjHttpClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingNestedObjWebClientJSON
            // 
            this.ModelBindingNestedObjWebClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjWebClientJSON.Location = new System.Drawing.Point(1456, 419);
            this.ModelBindingNestedObjWebClientJSON.Multiline = true;
            this.ModelBindingNestedObjWebClientJSON.Name = "ModelBindingNestedObjWebClientJSON";
            this.ModelBindingNestedObjWebClientJSON.ReadOnly = true;
            this.ModelBindingNestedObjWebClientJSON.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingNestedObjWebClientJSON.TabIndex = 97;
            this.ModelBindingNestedObjWebClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Orange;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(826, 646);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(188, 49);
            this.label16.TabIndex = 101;
            this.label16.Text = "ModelBindingArrayNestedObj( WebClient )";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Orange;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(826, 700);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(188, 49);
            this.label17.TabIndex = 102;
            this.label17.Text = "ModelBindingArrayNestedObj( RestCSharp )";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Orange;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(826, 756);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(188, 49);
            this.label18.TabIndex = 103;
            this.label18.Text = "ModelBindingArrayNestedObj( WebApiContrib )";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayNestedObjWebApiContribJSON
            // 
            this.ModelBindingArrayNestedObjWebApiContribJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjWebApiContribJSON.Location = new System.Drawing.Point(1457, 755);
            this.ModelBindingArrayNestedObjWebApiContribJSON.Multiline = true;
            this.ModelBindingArrayNestedObjWebApiContribJSON.Name = "ModelBindingArrayNestedObjWebApiContribJSON";
            this.ModelBindingArrayNestedObjWebApiContribJSON.ReadOnly = true;
            this.ModelBindingArrayNestedObjWebApiContribJSON.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayNestedObjWebApiContribJSON.TabIndex = 111;
            this.ModelBindingArrayNestedObjWebApiContribJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayNestedObjRestCSharpJSON
            // 
            this.ModelBindingArrayNestedObjRestCSharpJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjRestCSharpJSON.Location = new System.Drawing.Point(1457, 701);
            this.ModelBindingArrayNestedObjRestCSharpJSON.Multiline = true;
            this.ModelBindingArrayNestedObjRestCSharpJSON.Name = "ModelBindingArrayNestedObjRestCSharpJSON";
            this.ModelBindingArrayNestedObjRestCSharpJSON.ReadOnly = true;
            this.ModelBindingArrayNestedObjRestCSharpJSON.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayNestedObjRestCSharpJSON.TabIndex = 110;
            this.ModelBindingArrayNestedObjRestCSharpJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayNestedObjHttpClientJSON
            // 
            this.ModelBindingArrayNestedObjHttpClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjHttpClientJSON.Location = new System.Drawing.Point(1457, 592);
            this.ModelBindingArrayNestedObjHttpClientJSON.Multiline = true;
            this.ModelBindingArrayNestedObjHttpClientJSON.Name = "ModelBindingArrayNestedObjHttpClientJSON";
            this.ModelBindingArrayNestedObjHttpClientJSON.ReadOnly = true;
            this.ModelBindingArrayNestedObjHttpClientJSON.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayNestedObjHttpClientJSON.TabIndex = 109;
            this.ModelBindingArrayNestedObjHttpClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayNestedObjWebClientJSON
            // 
            this.ModelBindingArrayNestedObjWebClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjWebClientJSON.Location = new System.Drawing.Point(1457, 647);
            this.ModelBindingArrayNestedObjWebClientJSON.Multiline = true;
            this.ModelBindingArrayNestedObjWebClientJSON.Name = "ModelBindingArrayNestedObjWebClientJSON";
            this.ModelBindingArrayNestedObjWebClientJSON.ReadOnly = true;
            this.ModelBindingArrayNestedObjWebClientJSON.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayNestedObjWebClientJSON.TabIndex = 108;
            this.ModelBindingArrayNestedObjWebClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayNestedObjWebApiContribURL
            // 
            this.ModelBindingArrayNestedObjWebApiContribURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjWebApiContribURL.Location = new System.Drawing.Point(1144, 755);
            this.ModelBindingArrayNestedObjWebApiContribURL.Multiline = true;
            this.ModelBindingArrayNestedObjWebApiContribURL.Name = "ModelBindingArrayNestedObjWebApiContribURL";
            this.ModelBindingArrayNestedObjWebApiContribURL.ReadOnly = true;
            this.ModelBindingArrayNestedObjWebApiContribURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayNestedObjWebApiContribURL.TabIndex = 107;
            this.ModelBindingArrayNestedObjWebApiContribURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayNestedObjRestCSharpURL
            // 
            this.ModelBindingArrayNestedObjRestCSharpURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjRestCSharpURL.Location = new System.Drawing.Point(1144, 701);
            this.ModelBindingArrayNestedObjRestCSharpURL.Multiline = true;
            this.ModelBindingArrayNestedObjRestCSharpURL.Name = "ModelBindingArrayNestedObjRestCSharpURL";
            this.ModelBindingArrayNestedObjRestCSharpURL.ReadOnly = true;
            this.ModelBindingArrayNestedObjRestCSharpURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayNestedObjRestCSharpURL.TabIndex = 106;
            this.ModelBindingArrayNestedObjRestCSharpURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayNestedObjHttpClientURL
            // 
            this.ModelBindingArrayNestedObjHttpClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjHttpClientURL.Location = new System.Drawing.Point(1144, 592);
            this.ModelBindingArrayNestedObjHttpClientURL.Multiline = true;
            this.ModelBindingArrayNestedObjHttpClientURL.Name = "ModelBindingArrayNestedObjHttpClientURL";
            this.ModelBindingArrayNestedObjHttpClientURL.ReadOnly = true;
            this.ModelBindingArrayNestedObjHttpClientURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayNestedObjHttpClientURL.TabIndex = 105;
            this.ModelBindingArrayNestedObjHttpClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayNestedObjWebClientURL
            // 
            this.ModelBindingArrayNestedObjWebClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjWebClientURL.Location = new System.Drawing.Point(1144, 647);
            this.ModelBindingArrayNestedObjWebClientURL.Multiline = true;
            this.ModelBindingArrayNestedObjWebClientURL.Name = "ModelBindingArrayNestedObjWebClientURL";
            this.ModelBindingArrayNestedObjWebClientURL.ReadOnly = true;
            this.ModelBindingArrayNestedObjWebClientURL.Size = new System.Drawing.Size(182, 50);
            this.ModelBindingArrayNestedObjWebClientURL.TabIndex = 104;
            this.ModelBindingArrayNestedObjWebClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Orange;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(10, 647);
            this.label19.Name = "label19";
            this.label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label19.Size = new System.Drawing.Size(185, 50);
            this.label19.TabIndex = 112;
            this.label19.Text = "SimpleModelBindArray( WebClient )";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Orange;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(10, 701);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label20.Size = new System.Drawing.Size(185, 50);
            this.label20.TabIndex = 113;
            this.label20.Text = "SimpleModelBindArray( RestCSharp )";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Orange;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(10, 755);
            this.label21.Name = "label21";
            this.label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label21.Size = new System.Drawing.Size(185, 50);
            this.label21.TabIndex = 114;
            this.label21.Text = "SimpleModelBindArray( WebApiContrib )";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleModelBindArrayWebApiContribJSON
            // 
            this.SimpleModelBindArrayWebApiContribJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindArrayWebApiContribJSON.Location = new System.Drawing.Point(639, 752);
            this.SimpleModelBindArrayWebApiContribJSON.Multiline = true;
            this.SimpleModelBindArrayWebApiContribJSON.Name = "SimpleModelBindArrayWebApiContribJSON";
            this.SimpleModelBindArrayWebApiContribJSON.ReadOnly = true;
            this.SimpleModelBindArrayWebApiContribJSON.Size = new System.Drawing.Size(182, 49);
            this.SimpleModelBindArrayWebApiContribJSON.TabIndex = 122;
            this.SimpleModelBindArrayWebApiContribJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleModelBindArrayRestCSharpJSON
            // 
            this.SimpleModelBindArrayRestCSharpJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindArrayRestCSharpJSON.Location = new System.Drawing.Point(639, 698);
            this.SimpleModelBindArrayRestCSharpJSON.Multiline = true;
            this.SimpleModelBindArrayRestCSharpJSON.Name = "SimpleModelBindArrayRestCSharpJSON";
            this.SimpleModelBindArrayRestCSharpJSON.ReadOnly = true;
            this.SimpleModelBindArrayRestCSharpJSON.Size = new System.Drawing.Size(182, 49);
            this.SimpleModelBindArrayRestCSharpJSON.TabIndex = 121;
            this.SimpleModelBindArrayRestCSharpJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleModelBindArrayWebClientJSON
            // 
            this.SimpleModelBindArrayWebClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindArrayWebClientJSON.Location = new System.Drawing.Point(639, 642);
            this.SimpleModelBindArrayWebClientJSON.Multiline = true;
            this.SimpleModelBindArrayWebClientJSON.Name = "SimpleModelBindArrayWebClientJSON";
            this.SimpleModelBindArrayWebClientJSON.ReadOnly = true;
            this.SimpleModelBindArrayWebClientJSON.Size = new System.Drawing.Size(182, 49);
            this.SimpleModelBindArrayWebClientJSON.TabIndex = 120;
            this.SimpleModelBindArrayWebClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleModelBindArrayWebApiContribURL
            // 
            this.SimpleModelBindArrayWebApiContribURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindArrayWebApiContribURL.Location = new System.Drawing.Point(326, 752);
            this.SimpleModelBindArrayWebApiContribURL.Multiline = true;
            this.SimpleModelBindArrayWebApiContribURL.Name = "SimpleModelBindArrayWebApiContribURL";
            this.SimpleModelBindArrayWebApiContribURL.ReadOnly = true;
            this.SimpleModelBindArrayWebApiContribURL.Size = new System.Drawing.Size(182, 50);
            this.SimpleModelBindArrayWebApiContribURL.TabIndex = 119;
            this.SimpleModelBindArrayWebApiContribURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleModelBindArrayRestCSharpURL
            // 
            this.SimpleModelBindArrayRestCSharpURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindArrayRestCSharpURL.Location = new System.Drawing.Point(326, 698);
            this.SimpleModelBindArrayRestCSharpURL.Multiline = true;
            this.SimpleModelBindArrayRestCSharpURL.Name = "SimpleModelBindArrayRestCSharpURL";
            this.SimpleModelBindArrayRestCSharpURL.ReadOnly = true;
            this.SimpleModelBindArrayRestCSharpURL.Size = new System.Drawing.Size(182, 50);
            this.SimpleModelBindArrayRestCSharpURL.TabIndex = 118;
            this.SimpleModelBindArrayRestCSharpURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleModelBindArrayHttpClientURL
            // 
            this.SimpleModelBindArrayHttpClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindArrayHttpClientURL.Location = new System.Drawing.Point(326, 589);
            this.SimpleModelBindArrayHttpClientURL.Multiline = true;
            this.SimpleModelBindArrayHttpClientURL.Name = "SimpleModelBindArrayHttpClientURL";
            this.SimpleModelBindArrayHttpClientURL.ReadOnly = true;
            this.SimpleModelBindArrayHttpClientURL.Size = new System.Drawing.Size(182, 50);
            this.SimpleModelBindArrayHttpClientURL.TabIndex = 117;
            this.SimpleModelBindArrayHttpClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleModelBindArrayHttpClientJSON
            // 
            this.SimpleModelBindArrayHttpClientJSON.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindArrayHttpClientJSON.Location = new System.Drawing.Point(639, 589);
            this.SimpleModelBindArrayHttpClientJSON.Multiline = true;
            this.SimpleModelBindArrayHttpClientJSON.Name = "SimpleModelBindArrayHttpClientJSON";
            this.SimpleModelBindArrayHttpClientJSON.ReadOnly = true;
            this.SimpleModelBindArrayHttpClientJSON.Size = new System.Drawing.Size(182, 49);
            this.SimpleModelBindArrayHttpClientJSON.TabIndex = 116;
            this.SimpleModelBindArrayHttpClientJSON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleModelBindArrayWebClientURL
            // 
            this.SimpleModelBindArrayWebClientURL.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindArrayWebClientURL.Location = new System.Drawing.Point(326, 644);
            this.SimpleModelBindArrayWebClientURL.Multiline = true;
            this.SimpleModelBindArrayWebClientURL.Name = "SimpleModelBindArrayWebClientURL";
            this.SimpleModelBindArrayWebClientURL.ReadOnly = true;
            this.SimpleModelBindArrayWebClientURL.Size = new System.Drawing.Size(182, 50);
            this.SimpleModelBindArrayWebClientURL.TabIndex = 115;
            this.SimpleModelBindArrayWebClientURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WinForm
            // 
            this.ClientSize = new System.Drawing.Size(1813, 852);
            this.Controls.Add(this.SimpleModelBindArrayWebApiContribJSON);
            this.Controls.Add(this.SimpleModelBindArrayRestCSharpJSON);
            this.Controls.Add(this.SimpleModelBindArrayWebClientJSON);
            this.Controls.Add(this.SimpleModelBindArrayWebApiContribURL);
            this.Controls.Add(this.SimpleModelBindArrayRestCSharpURL);
            this.Controls.Add(this.SimpleModelBindArrayHttpClientURL);
            this.Controls.Add(this.SimpleModelBindArrayHttpClientJSON);
            this.Controls.Add(this.SimpleModelBindArrayWebClientURL);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ModelBindingArrayNestedObjWebApiContribJSON);
            this.Controls.Add(this.ModelBindingArrayNestedObjRestCSharpJSON);
            this.Controls.Add(this.ModelBindingArrayNestedObjHttpClientJSON);
            this.Controls.Add(this.ModelBindingArrayNestedObjWebClientJSON);
            this.Controls.Add(this.ModelBindingArrayNestedObjWebApiContribURL);
            this.Controls.Add(this.ModelBindingArrayNestedObjRestCSharpURL);
            this.Controls.Add(this.ModelBindingArrayNestedObjHttpClientURL);
            this.Controls.Add(this.ModelBindingArrayNestedObjWebClientURL);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ModelBindingNestedObjWebApiContribJSON);
            this.Controls.Add(this.ModelBindingNestedObjRestCSharpJSON);
            this.Controls.Add(this.ModelBindingNestedObjHttpClientJSON);
            this.Controls.Add(this.ModelBindingNestedObjWebClientJSON);
            this.Controls.Add(this.ModelBindingNestedObjWebApiContribURL);
            this.Controls.Add(this.ModelBindingNestedObjRestCSharpURL);
            this.Controls.Add(this.ModelBindingNestedObjHttpClientURL);
            this.Controls.Add(this.ModelBindingNestedObjWebClientURL);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ModelBindingArrayWebApiContribJSON);
            this.Controls.Add(this.ModelBindingArrayRestCSharpJSON);
            this.Controls.Add(this.ModelBindingArrayWebClientJSON);
            this.Controls.Add(this.ModelBindingArrayWebApiContribURL);
            this.Controls.Add(this.ModelBindingArrayRestCSharpURL);
            this.Controls.Add(this.ModelBindingArrayHttpClientURL);
            this.Controls.Add(this.ModelBindingArrayHttpClientJSON);
            this.Controls.Add(this.ModelBindingArrayWebClientURL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModelBindingObjWebApiContribJSON);
            this.Controls.Add(this.ModelBindingObjRestCSharpJSON);
            this.Controls.Add(this.ModelBindingObjWebClientJSON);
            this.Controls.Add(this.ModelBindingObjWebApiContribURL);
            this.Controls.Add(this.ModelBindingObjRestCSharpURL);
            this.Controls.Add(this.ModelBindingObjHttpClientURL);
            this.Controls.Add(this.ModelBindingObjHttpClientJSON);
            this.Controls.Add(this.ModelBindingObjWebClientURL);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SimpleBindingWebApiContribJSON);
            this.Controls.Add(this.SimpleBindingRestCSharpJSON);
            this.Controls.Add(this.SimpleBindingWebClientJSON);
            this.Controls.Add(this.SimpleBindingWebApiContribURL);
            this.Controls.Add(this.SimpleBindingRestCSharpURL);
            this.Controls.Add(this.SimpleBindingHttpClientURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Urlencoded);
            this.Controls.Add(this.SimpleBindingHttpClientJSON);
            this.Controls.Add(this.SimpleBindingTItle);
            this.Controls.Add(this.SimpleBindingWebClientURL);
            this.Controls.Add(this.ModelBindingArrayNestedObjTitle);
            this.Controls.Add(this.SimpleModelBindArrayTitle);
            this.Controls.Add(this.ModelBindingNestedObjTitle);
            this.Controls.Add(this.ModelBindingArrayTitle);
            this.Controls.Add(this.ModelBindObjTitle);
            this.Controls.Add(this.AgeFour);
            this.Controls.Add(this.NameFour);
            this.Controls.Add(this.AgeThr);
            this.Controls.Add(this.NameThr);
            this.Controls.Add(this.AgeTwo);
            this.Controls.Add(this.NameTwo);
            this.Controls.Add(this.AgeOne);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameOne);
            this.Controls.Add(this.button1);
            this.Name = "WinForm";
            this.Load += new System.EventHandler(this.WinForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            //WebApiConClient WebApiFunc = new WebApiConClient();

            RestSharpRequest RestSharpFunc = new RestSharpRequest();
            OtherHttpRequest ComposAndRequest = new OtherHttpRequest();
            string[] NameInput = { NameOne.Text, NameTwo.Text, NameThr.Text, NameFour.Text };
            string[] AgeInput = { AgeOne.Text, AgeTwo.Text, AgeThr.Text, AgeFour.Text };
            List<string> Name = new List<string>();
            List<string> Age = new List<string>();
            for (int i = 0; i < NameInput.Length; i++)
            {
                if (!string.IsNullOrEmpty(NameInput[i]) && !string.IsNullOrEmpty(AgeInput[i]))
                {
                    Name.Add(NameInput[i]);
                    Age.Add(AgeInput[i]);
                }
                else
                {
                    continue;
                }
            }


            //SimpleBinding
            SimpleBinding(Name,Age,RestSharpFunc, ComposAndRequest);


            //ModelBinObj
            ModelBindObj(Name, Age, RestSharpFunc, ComposAndRequest);


            ////SimpleModelBindArray
            SimpleModelBindingArray(Name, Age,RestSharpFunc, ComposAndRequest);


            //ModelBindingArray
            ModelBindingArray(Name, Age,RestSharpFunc, ComposAndRequest);

            //ModelBindingNestedObj
            ModelBindingNestedObj(Name, Age,RestSharpFunc, ComposAndRequest);


            //ModelBindingArrayNestedObj
            ModelBindingArrayNestedObj(Name, Age,RestSharpFunc, ComposAndRequest);

        }

        private void SimpleBinding(List<string> Name,List<string> Age, RestSharpRequest RestSharpFunc, OtherHttpRequest ComposAndRequest)
        {
            try
            {
                
                Uri BaseURL = new Uri("https://localhost:44376/api/Home/SimpleBinding");
                //Uri WebApiBaseURL = new Uri("https://localhost:44376/api/WebApiContribPackage/SimpleBinding");


                    // HttpClient
                    SimpleBindingHttpClientURL.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "SimpleBinding", "application/x-www-form-urlencoded", "HttpClient");
                    SimpleBindingHttpClientJSON.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "SimpleBinding", "application/json", "HttpClient");
                
                    // WebClient
                    SimpleBindingWebClientURL.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "SimpleBinding", "application/x-www-form-urlencoded", "WebClient");
                    SimpleBindingWebClientJSON.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "SimpleBinding", "application/json", "WebClient");


                // RestCSharp
                SimpleBindingRestCSharpURL.Text = RestSharpFunc.ComposeQueryString(Name, Age, BaseURL, "SimpleBinding", "application/x-www-form-urlencoded");
                SimpleBindingRestCSharpJSON.Text = RestSharpFunc.ComposeQueryString(Name, Age, BaseURL, "SimpleBinding", "application/json");

                // WebApiContrib
                //SimpleBindingWebApiContribURL.Text = WebApiFunc.ComposeQueryString(Name, Age, WebApiBaseURL, "application/x-www-form-urlencoded");
                //SimpleBindingWebApiContribJSON.Text = WebApiFunc.ComposeQueryString(Name, Age, WebApiBaseURL, "application/json");

            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }
        }

        private void ModelBindObj(List<string> Name, List<string> Age,RestSharpRequest RestSharpFunc, OtherHttpRequest ComposAndRequest)
        {
            try
            {
                Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindObj");

                    // HttpClient
                    ModelBindingObjHttpClientURL.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindObj", "application/x-www-form-urlencoded", "HttpClient");
                    ModelBindingObjHttpClientJSON.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindObj", "application/json", "HttpClient");
                
                    // WebClient
                    ModelBindingObjWebClientURL.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindObj", "application/x-www-form-urlencoded", "WebClient");
                    ModelBindingObjWebClientJSON.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindObj", "application/json","WebClient");

                    // RestCSharp
                    ModelBindingObjRestCSharpURL.Text = RestSharpFunc.ComposeQueryString(Name, Age, BaseURL, "ModelBindObj", "application/x-www-form-urlencoded");
                    ModelBindingObjRestCSharpJSON.Text = RestSharpFunc.ComposeQueryString(Name, Age, BaseURL, "ModelBindObj", "application/json");
            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }

        }

        private void SimpleModelBindingArray(List<string> Name, List<string> Age, RestSharpRequest RestSharpFunc, OtherHttpRequest ComposAndRequest)
        {
            try
            {
                Uri BaseURL = new Uri("https://localhost:44376/api/Home/SimpleModelBindArray");

      
                    // HttpClient
                    SimpleModelBindArrayHttpClientURL.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "SimpleModelBindingArray", "application/x-www-form-urlencoded", "HttpClient");
                    SimpleModelBindArrayHttpClientJSON.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "SimpleModelBindingArray", "application/json", "HttpClient");
                
                    // WebClient
                    SimpleModelBindArrayWebClientURL.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "SimpleModelBindingArray", "application/x-www-form-urlencoded", "WebClient");
                    SimpleModelBindArrayWebClientJSON.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "SimpleModelBindingArray", "application/json", "WebClient");

                    // RestCSharp
                    SimpleModelBindArrayRestCSharpURL.Text = RestSharpFunc.ComposeQueryString(Name, Age, BaseURL, "SimpleModelBindingArray", "application/x-www-form-urlencoded");
                    SimpleModelBindArrayRestCSharpJSON.Text = RestSharpFunc.ComposeQueryString(Name, Age, BaseURL, "SimpleModelBindingArray", "application/json");
            
            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }
        }

        private void ModelBindingArray(List<string> Name, List<string> Age, RestSharpRequest RestSharpFunc, OtherHttpRequest ComposAndRequest)
        {
            try
            {
                Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingArray");

              
                    // HttpClient
                    ModelBindingArrayHttpClientURL.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindingArray", "application/x-www-form-urlencoded", "HttpClient");
                    ModelBindingArrayHttpClientJSON.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindingArray", "application/json", "HttpClient");
                
                    // WebClient
                    ModelBindingArrayWebClientURL.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindingArray", "application/x-www-form-urlencoded", "WebClient");
                    ModelBindingArrayWebClientJSON.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindingArray", "application/json", "WebClient");

                // RestCSharp
                ModelBindingArrayRestCSharpURL.Text = RestSharpFunc.ComposeQueryString(Name, Age, BaseURL, "ModelBindingArray", "application/x-www-form-urlencoded");
                ModelBindingArrayRestCSharpJSON.Text = RestSharpFunc.ComposeQueryString(Name, Age, BaseURL, "ModelBindingArray", "application/json");

            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }
        }

        private void ModelBindingNestedObj(List<string> Name, List<string> Age,RestSharpRequest RestSharpFunc, OtherHttpRequest ComposAndRequest)
        {

            try
            {
                Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingNestedObj");

                // HttpClient
                ModelBindingNestedObjHttpClientURL.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindingNestedObj", "application/x-www-form-urlencoded", "HttpClient");
                ModelBindingNestedObjHttpClientJSON.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindingNestedObj", "application/json", "HttpClient");

                // WebClient
                ModelBindingNestedObjWebClientURL.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindingNestedObj", "application/x-www-form-urlencoded", "WebClient");
                ModelBindingNestedObjWebClientJSON.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindingNestedObj", "application/json", "WebClient");

                // RestCSharp
                ModelBindingNestedObjRestCSharpURL.Text = RestSharpFunc.ComposeQueryString(Name, Age, BaseURL, "ModelBindingNestedObj", "application/x-www-form-urlencoded");
                ModelBindingNestedObjRestCSharpJSON.Text = RestSharpFunc.ComposeQueryString(Name, Age, BaseURL, "ModelBindingNestedObj", "application/json");
            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }

        }

        private void ModelBindingArrayNestedObj(List<string> Name, List<string> Age, RestSharpRequest RestSharpFunc, OtherHttpRequest ComposAndRequest)
        {
            try
            {
                Uri BaseURL = new Uri("https://localhost:44376/api/Home/ModelBindingArrayNestedObj");

                // HttpClient
                ModelBindingArrayNestedObjHttpClientURL.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindingArrayNestedObj", "application/x-www-form-urlencoded", "HttpClient");
                ModelBindingArrayNestedObjHttpClientJSON.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindingArrayNestedObj", "application/json", "HttpClient");


                // WebClient
                ModelBindingArrayNestedObjWebClientURL.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindingArrayNestedObj", "application/x-www-form-urlencoded", "WebClient");
                ModelBindingArrayNestedObjWebClientJSON.Text = ComposAndRequest.ComposeQueryString(Name, Age, BaseURL, "ModelBindingArrayNestedObj", "application/json", "WebClient");

                // RestCSharp
                ModelBindingArrayNestedObjRestCSharpURL.Text = RestSharpFunc.ComposeQueryString(Name, Age, BaseURL, "ModelBindingArrayNestedObj", "application/x-www-form-urlencoded");
                ModelBindingArrayNestedObjRestCSharpJSON.Text = RestSharpFunc.ComposeQueryString(Name, Age, BaseURL, "ModelBindingArrayNestedObj", "application/json");
            }
            catch (Exception error)
            {
                Console.WriteLine("{0}", error.Message);
            }
        }



        private void WinForm_Load_1(object sender, EventArgs e)
        {

        }

        private void NameOne_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
