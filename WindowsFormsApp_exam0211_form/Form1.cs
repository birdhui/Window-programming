using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_exam0211_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inch2cm_Click(object sender, EventArgs e)
        // 버튼 클릭 이벤트 - 이벤트 발생시 InchBox에 입력한 값을 가져옴
        {
            // 소수점 개수가 1이거나 이하이고, InchBox.Text값이 부동 소수점 숫자라면
            if (InchdecimalCount <= 1 && float.TryParse(InchBox.Text, out float val))
            {
                // 값을 cm로 변환 후 'cmLabel' 텍스트를 변환된 값으로 설정, 인치 값을 2.54 곱함
                cmLabel.Text = (val * 2.54).ToString();
                InchdecimalCount = 0; // 변환 후 소수점 개수 초기화
            }
            else
                // 부동 소수점 숫자가 아닐 시 'cmLabel'의 텍스트 ERROR 표시
                cmLabel.Text = "ERROR";
        }

        // 소수점 개수 저장
        private int InchdecimalCount = 0;
        private void InchBox_KeyPress(object sender, KeyPressEventArgs e)
        // 텍스트 상자에서 키를 누를 때 발생하는 키 누름 이벤트 처리 메소드
        {
            // 입력된 키가 소수점 키라면
            if (e.KeyChar == Convert.ToChar(46))
            {
                // 소수점 키가 이미 입력된 경우
                if (InchdecimalCount > 0)
                {
                    // 키 입력 무시
                    e.Handled = true;
                }
                // 아니라면
                else
                {
                    // 소수점 개수 증가
                    InchdecimalCount++;
                }
            }
            // 숫자, 백스페이스 및 소수점이 아닌 경우 입력 무시
            else if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void kg2pound_Click(object sender, EventArgs e)
        {
            // 소수점 개수가 1이거나 이하이고, InchBox.Text값이 부동 소수점 숫자라면
            if (kgdecimalCount <= 1 && float.TryParse(KgBox.Text, out float val))
            {
                // 값을 cm로 변환 후 'cmLabel' 텍스트를 변환된 값으로 설정, 인치 값을 2.54 곱함
                poundLabel.Text = (float.Parse(KgBox.Text) * 2.20462262).ToString();
                kgdecimalCount = 0; // 변환 후 소수점 개수 초기화
            }
            else
                // 부동 소수점 숫자가 아닐 시 'cmLabel'의 텍스트 ERROR 표시
                poundLabel.Text = "ERROR";
        }

        private int kgdecimalCount = 0;
        private void KgBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 입력된 키가 소수점 키라면
            if (e.KeyChar == Convert.ToChar(46))
            {
                // 소수점 키가 이미 입력된 경우
                if (kgdecimalCount > 0)
                {
                    // 키 입력 무시
                    e.Handled = true;
                }
                // 아니라면
                else
                {
                    // 소수점 개수 증가
                    kgdecimalCount++;
                }
            }
            // 숫자, 백스페이스 및 소수점이 아닌 경우 입력 무시
            else if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void KgBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kg2pound_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        
    }
}
