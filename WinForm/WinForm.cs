using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
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
            this.ModelBinObj = new System.Windows.Forms.TextBox();
            this.ModelBindObjTitle = new System.Windows.Forms.Label();
            this.ModelBindingArrayTitle = new System.Windows.Forms.Label();
            this.ModelBindingArray = new System.Windows.Forms.TextBox();
            this.ModelBindingNestedObjTitle = new System.Windows.Forms.Label();
            this.ModelBindingNestedObj = new System.Windows.Forms.TextBox();
            this.SimpleModelBindingTitle = new System.Windows.Forms.Label();
            this.SimpleModelBinding = new System.Windows.Forms.TextBox();
            this.ModelBindingArrayNestedObjTitle = new System.Windows.Forms.Label();
            this.ModelBindingArrayNestedObj = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(844, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(447, 90);
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
            // ModelBinObj
            // 
            this.ModelBinObj.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBinObj.Location = new System.Drawing.Point(12, 136);
            this.ModelBinObj.Multiline = true;
            this.ModelBinObj.Name = "ModelBinObj";
            this.ModelBinObj.ReadOnly = true;
            this.ModelBinObj.Size = new System.Drawing.Size(271, 122);
            this.ModelBinObj.TabIndex = 23;
            this.ModelBinObj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindObjTitle
            // 
            this.ModelBindObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindObjTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindObjTitle.Location = new System.Drawing.Point(289, 136);
            this.ModelBindObjTitle.Name = "ModelBindObjTitle";
            this.ModelBindObjTitle.Size = new System.Drawing.Size(185, 121);
            this.ModelBindObjTitle.TabIndex = 24;
            this.ModelBindObjTitle.Text = "ModelBindingObj";
            this.ModelBindObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayTitle
            // 
            this.ModelBindingArrayTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingArrayTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayTitle.Location = new System.Drawing.Point(289, 264);
            this.ModelBindingArrayTitle.Name = "ModelBindingArrayTitle";
            this.ModelBindingArrayTitle.Size = new System.Drawing.Size(185, 121);
            this.ModelBindingArrayTitle.TabIndex = 26;
            this.ModelBindingArrayTitle.Text = "ModelBindingArray";
            this.ModelBindingArrayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArray
            // 
            this.ModelBindingArray.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArray.Location = new System.Drawing.Point(12, 264);
            this.ModelBindingArray.Multiline = true;
            this.ModelBindingArray.Name = "ModelBindingArray";
            this.ModelBindingArray.ReadOnly = true;
            this.ModelBindingArray.Size = new System.Drawing.Size(271, 122);
            this.ModelBindingArray.TabIndex = 25;
            this.ModelBindingArray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingNestedObjTitle
            // 
            this.ModelBindingNestedObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingNestedObjTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObjTitle.Location = new System.Drawing.Point(289, 392);
            this.ModelBindingNestedObjTitle.Name = "ModelBindingNestedObjTitle";
            this.ModelBindingNestedObjTitle.Size = new System.Drawing.Size(185, 251);
            this.ModelBindingNestedObjTitle.TabIndex = 28;
            this.ModelBindingNestedObjTitle.Text = "ModelBindingNestedObj";
            this.ModelBindingNestedObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingNestedObj
            // 
            this.ModelBindingNestedObj.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingNestedObj.Location = new System.Drawing.Point(12, 392);
            this.ModelBindingNestedObj.Multiline = true;
            this.ModelBindingNestedObj.Name = "ModelBindingNestedObj";
            this.ModelBindingNestedObj.ReadOnly = true;
            this.ModelBindingNestedObj.Size = new System.Drawing.Size(271, 251);
            this.ModelBindingNestedObj.TabIndex = 27;
            this.ModelBindingNestedObj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SimpleModelBindingTitle
            // 
            this.SimpleModelBindingTitle.BackColor = System.Drawing.Color.Orange;
            this.SimpleModelBindingTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBindingTitle.Location = new System.Drawing.Point(757, 264);
            this.SimpleModelBindingTitle.Name = "SimpleModelBindingTitle";
            this.SimpleModelBindingTitle.Size = new System.Drawing.Size(185, 121);
            this.SimpleModelBindingTitle.TabIndex = 30;
            this.SimpleModelBindingTitle.Text = "SimpleModelBinding";
            this.SimpleModelBindingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SimpleModelBinding
            // 
            this.SimpleModelBinding.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleModelBinding.Location = new System.Drawing.Point(480, 264);
            this.SimpleModelBinding.Multiline = true;
            this.SimpleModelBinding.Name = "SimpleModelBinding";
            this.SimpleModelBinding.ReadOnly = true;
            this.SimpleModelBinding.Size = new System.Drawing.Size(271, 122);
            this.SimpleModelBinding.TabIndex = 29;
            this.SimpleModelBinding.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ModelBindingArrayNestedObjTitle
            // 
            this.ModelBindingArrayNestedObjTitle.BackColor = System.Drawing.Color.Orange;
            this.ModelBindingArrayNestedObjTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObjTitle.Location = new System.Drawing.Point(757, 136);
            this.ModelBindingArrayNestedObjTitle.Name = "ModelBindingArrayNestedObjTitle";
            this.ModelBindingArrayNestedObjTitle.Size = new System.Drawing.Size(185, 121);
            this.ModelBindingArrayNestedObjTitle.TabIndex = 32;
            this.ModelBindingArrayNestedObjTitle.Text = "ModelBindingArrayNestedObj";
            this.ModelBindingArrayNestedObjTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModelBindingArrayNestedObj
            // 
            this.ModelBindingArrayNestedObj.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModelBindingArrayNestedObj.Location = new System.Drawing.Point(480, 136);
            this.ModelBindingArrayNestedObj.Multiline = true;
            this.ModelBindingArrayNestedObj.Name = "ModelBindingArrayNestedObj";
            this.ModelBindingArrayNestedObj.ReadOnly = true;
            this.ModelBindingArrayNestedObj.Size = new System.Drawing.Size(271, 122);
            this.ModelBindingArrayNestedObj.TabIndex = 31;
            this.ModelBindingArrayNestedObj.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WinForm
            // 
            this.ClientSize = new System.Drawing.Size(1303, 655);
            this.Controls.Add(this.ModelBindingArrayNestedObjTitle);
            this.Controls.Add(this.ModelBindingArrayNestedObj);
            this.Controls.Add(this.SimpleModelBindingTitle);
            this.Controls.Add(this.SimpleModelBinding);
            this.Controls.Add(this.ModelBindingNestedObjTitle);
            this.Controls.Add(this.ModelBindingNestedObj);
            this.Controls.Add(this.ModelBindingArrayTitle);
            this.Controls.Add(this.ModelBindingArray);
            this.Controls.Add(this.ModelBindObjTitle);
            this.Controls.Add(this.ModelBinObj);
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
            //string[] Name = { NameOne.Text, NameTwo.Text, NameThr.Text, NameFour.Text };
            //int[] Age = {Int32.Parse(AgeOne.Text),Int32.Parse(AgeTwo.Text), Int32.Parse(AgeThr.Text), Int32.Parse(AgeFour.Text) };
            //HTTPRequestHandle(Name, Age);
            using (HttpClient client = new HttpClient())
            {
                //ModelBinObj
                //string Name = NameOne.Text;
                //int Age = Int32.Parse(AgeOne.Text);
                //Human data = new Human();
                //data.Name = Name;
                //data.Age = Age;
                //string JSON = JsonConvert.SerializeObject(data);
                //HttpContent PostContent = new StringContent(JSON, Encoding.UTF8, "application/json");
                //HttpResponseMessage response = await client.PostAsync("https://localhost:44376/api/Home/ModelBindObj", PostContent);
                //response.EnsureSuccessStatusCode();
                //string ResponseBody = await response.Content.ReadAsStringAsync();
                //ModelBinObj.Text = ResponseBody;



                //ModelBindingArray
                //string[] Name = { NameOne.Text, NameTwo.Text};
                //int[] Age = { Int32.Parse(AgeOne.Text), Int32.Parse(AgeTwo.Text)};
                //List<Human> data = new List<Human>();
                //for (int i = 0; i < Name.Length; i++)
                //{
                //    Human T = new Human();
                //    T.Name = Name[i];
                //    T.Age = Age[i];
                //    data.Add(T);
                //}
                //string JSON = JsonConvert.SerializeObject(data);
                //HttpContent PostContent = new StringContent(JSON, Encoding.UTF8, "application/json");
                //HttpResponseMessage response = await client.PostAsync("https://localhost:44376/api/Home/ModelBindingArray", PostContent);
                //response.EnsureSuccessStatusCode();
                //string ResponseBody = await response.Content.ReadAsStringAsync();
                //ModelBindingArray.Text = ResponseBody;



                //ModelBindingNestedObj
                //string[] Name = { NameOne.Text, NameTwo.Text,NameThr.Text };
                //int[] Age = { Int32.Parse(AgeOne.Text), Int32.Parse(AgeTwo.Text), Int32.Parse(AgeThr.Text) };
                //Person data = new Person();
                //List<Person> F = new List<Person>();
                //data.Name = NameFour.Text;
                //data.Age = Int32.Parse(AgeFour.Text);
                //for (int i = 0; i < Name.Length; i++)
                //{
                //    Person Friends = new Person();
                //    Friends.Name = Name[i];
                //    Friends.Age = Age[i];
                //    F.Add(Friends);
                //    data.Friends = F;
                //}

                //string JSON = JsonConvert.SerializeObject(data);
                //HttpContent PostContent = new StringContent(JSON, Encoding.UTF8, "application/json");
                //HttpResponseMessage response = await client.PostAsync("https://localhost:44376/api/Home/ModelBindingNestedObj", PostContent);
                //response.EnsureSuccessStatusCode();
                //string ResponseBody = await response.Content.ReadAsStringAsync();
                //ModelBindingNestedObj.Text = ResponseBody;




                //ModelBindingArrayNestedObj
                //string[] Name = { NameOne.Text, NameTwo.Text, NameThr.Text };
                //int[] Age = { Int32.Parse(AgeOne.Text), Int32.Parse(AgeTwo.Text), Int32.Parse(AgeThr.Text) };
                //List<Person> A = new List<Person>();
                //Person data = new Person();
                //List<Person> F = new List<Person>();
                //data.Name = NameFour.Text;
                //data.Age = Int32.Parse(AgeFour.Text);
                //for (int i = 0; i < Name.Length; i++)
                //{
                //    Person Friends = new Person();
                //    Friends.Name = Name[i];
                //    Friends.Age = Age[i];
                //    F.Add(Friends);
                //    data.Friends = F;
                //}
                //A.Add(data);
                //string JSON = JsonConvert.SerializeObject(A);
                //HttpContent PostContent = new StringContent(JSON, Encoding.UTF8, "application/json");
                //HttpResponseMessage response = await client.PostAsync("https://localhost:44376/api/Home/ModelBindingArrayNestedObj", PostContent);
                //response.EnsureSuccessStatusCode();
                //string ResponseBody = await response.Content.ReadAsStringAsync();
                //ModelBindingArrayNestedObj.Text = ResponseBody;




                //SimpleBinding
                //string Name = NameOne.Text;
                //string Age = AgeOne.Text;
                //Human data = new Human();
                //Dictionary<string, string> formDataDic = new Dictionary<string, string>()
                //{
                //    {nameof(data.Name),Name },
                //    {nameof(data.Age),Age },
                //};
                //client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");
                //var formData = new FormUrlEncodedContent(formDataDic);
                //HttpResponseMessage response = await client.PostAsync("https://localhost:44376/api/Home/SimpleBinding", formData);
                //response.EnsureSuccessStatusCode();
                //string ResponseBody = await response.Content.ReadAsStringAsync();
                //SimpleModelBinding.Text = ResponseBody;



                //SimpleModelBindArray
                string[] Name = { NameOne.Text, NameTwo.Text };
                int[] Age = { Int32.Parse(AgeOne.Text), Int32.Parse(AgeTwo.Text) };
                Human data = new Human();
                Dictionary<string, string> formDataDic = new Dictionary<string, string>()
                {
                    {nameof(data.Name),Name[0] },
                    {nameof(data.Name),Name[1] },
                    {nameof(data.Age),Age[0].ToString() },
                    {nameof(data.Age),Age[1].ToString() },
                };

                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded");
                var formData = new FormUrlEncodedContent(formDataDic);
                HttpResponseMessage response = await client.PostAsync("https://localhost:44376/api/Home/SimpleModelBindArray", formData);
                response.EnsureSuccessStatusCode();
                string ResponseBody = await response.Content.ReadAsStringAsync();
                SimpleModelBinding.Text = ResponseBody;


            }
        }
        private void WinForm_Load_1(object sender, EventArgs e)
        {

        }

        private void NameOne_TextChanged(object sender, EventArgs e)
        {

        }

        private void HTTPRequestHandle(string[]Name,int[]Age)
        {
            using(HttpClient client=new HttpClient())
            {

            }
        }
    }
}
