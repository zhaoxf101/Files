//����ҲҪע��һ�°�

//����, Ҫ�õ�һ��WimdowsAPI����, ��˱�������
//using System.Runtime.InteropServices; 
//�����ռ�; 

//Ȼ��,���������ַ���,һ��ʹ��API, һ�ֲ���,��дWndProc���ڹ��̵ķ�ʽ����ҪAPI��������һ��������Ҫ������ 
//SendMessage ��ָ�����ڹ��̷�����Ϣ
//ReleaseCapture �ͷ���겶��

//�����һЩ��Ҫ�ĳ�����������Щ����������MSDN����CPPͷ�ļ����ҵ��� 
//private const int WM_SYSCOMMAND = 0x0112;//����������Ͻ��Ǹ�ͼ��ʱ��ϵͳ��Ϣ 
//private const int SC_MOVE = 0xF010;//�ƶ���Ϣ 
//private const int HTCAPTION = 0x0002;//��ʾ����ڴ��ڱ�����ʱ��ϵͳ��Ϣ 
//private const int WM_NCHITTEST = 0x84;//����ڴ���ͻ��������˱������ͱ߿�����Ĳ��֣�ʱ���͵���Ϣ 
//private const int HTCLIENT = 0x1;//��ʾ����ڴ��ڿͻ�����ϵͳ��Ϣ 
//private const int SC_MAXIMIZE = 0xF030;//�����Ϣ 
//private const int SC_MINIMIZE = 0xF020;//��С����Ϣ 

using System; 
using System.Collections.Generic; 
using System.ComponentModel; 
using System.Data; 
using System.Drawing; 
using System.Text; 
using System.Windows.Forms; 
using System.Runtime.InteropServices; 

namespace WindowsApplicationTestNoBoarderAndMove
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private const int WM_SYSCOMMAND = 0x0112;//����������Ͻ��Ǹ�ͼ��ʱ��ϵͳ��Ϣ 
        private const int SC_MOVE = 0xF010;//�ƶ���Ϣ 
        private const int HTCAPTION = 0x0002;//��ʾ����ڴ��ڱ�����ʱ��ϵͳ��Ϣ 
        private const int WM_NCHITTEST = 0x84;//����ڴ���ͻ��������˱������ͱ߿�����Ĳ��֣�ʱ���͵���Ϣ 
        private const int HTCLIENT = 0x1;//��ʾ����ڴ��ڿͻ�����ϵͳ��Ϣ 
        private const int SC_MAXIMIZE = 0xF030;//�����Ϣ 
        private const int SC_MINIMIZE = 0xF020;//��С����Ϣ 

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //����Ĵ�������//ע����һ�£���������ʵ�ַ��� 

        //private void Form1_MouseDown(object sender, MouseEventArgs e) 
        //{ 
        // ReleaseCapture();//�����ͷ���꽹�㲶�������Ͳ����ٷ���WM_NCHITTEST��Ϣ 
        // SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//Ȼ����ǰ���巢����Ϣ����Ϣ���ƶ�+��ʾ����ڱ������� 
        //} 


        //�����������д�ķ������Ͱ�����Ĳ���ע�͵����� 

        /**/
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_SYSCOMMAND:
                    if (m.WParam == (IntPtr)SC_MAXIMIZE)
                    {
                        m.WParam = (IntPtr)SC_MINIMIZE;
                    }
                    break;
                case WM_NCHITTEST: //�������ƶ��򵥻� 
                    base.WndProc(ref m);//���û���Ĵ��ڹ��̡���WndProc�������������Ϣ 
                    if (m.Result == (IntPtr)HTCLIENT)//������ص���HTCLIENT 
                    {
                        m.Result = (IntPtr)HTCAPTION;//������ΪHTCAPTION 
                        return;//ֱ�ӷ����˳����� 
                    }
                    break;
            }
            base.WndProc(ref m);//�����������ƶ��򵥻���Ϣ�͵��û���Ĵ��ڹ��̽��д��� 
        }


        //�ú��������д�ķ����и�����~~~ 
        //��£�������ڴ�����˫����꣬�ᷢ��ʲô���Ǻǣ��������󻯡��� 
    }
}

