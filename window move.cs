//多少也要注释一下吧

//首先, 要用到一个WimdowsAPI函数, 因此必须引入
//using System.Runtime.InteropServices; 
//命名空间; 

//然后,这里有两种方法,一种使用API, 一种不用,重写WndProc窗口过程的方式不需要API函数。另一个方法需要两个： 
//SendMessage 像指定窗口过程发送消息
//ReleaseCapture 释放鼠标捕获

//最后是一些必要的常数声明，这些声明可以在MSDN或者CPP头文件中找到： 
//private const int WM_SYSCOMMAND = 0x0112;//点击窗口左上角那个图标时的系统信息 
//private const int SC_MOVE = 0xF010;//移动信息 
//private const int HTCAPTION = 0x0002;//表示鼠标在窗口标题栏时的系统信息 
//private const int WM_NCHITTEST = 0x84;//鼠标在窗体客户区（除了标题栏和边框以外的部分）时发送的消息 
//private const int HTCLIENT = 0x1;//表示鼠标在窗口客户区的系统消息 
//private const int SC_MAXIMIZE = 0xF030;//最大化信息 
//private const int SC_MINIMIZE = 0xF020;//最小化信息 

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

        private const int WM_SYSCOMMAND = 0x0112;//点击窗口左上角那个图标时的系统信息 
        private const int SC_MOVE = 0xF010;//移动信息 
        private const int HTCAPTION = 0x0002;//表示鼠标在窗口标题栏时的系统信息 
        private const int WM_NCHITTEST = 0x84;//鼠标在窗体客户区（除了标题栏和边框以外的部分）时发送的消息 
        private const int HTCLIENT = 0x1;//表示鼠标在窗口客户区的系统消息 
        private const int SC_MAXIMIZE = 0xF030;//最大化信息 
        private const int SC_MINIMIZE = 0xF020;//最小化信息 

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //下面的代码我用//注释了一下，这是两种实现方法 

        //private void Form1_MouseDown(object sender, MouseEventArgs e) 
        //{ 
        // ReleaseCapture();//首先释放鼠标焦点捕获，这样就不会再发出WM_NCHITTEST消息 
        // SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);//然后向当前窗体发送消息，消息是移动+表示鼠标在标题栏上 
        //} 


        //如果用这种重写的方法，就把上面的部分注释掉…… 

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
                case WM_NCHITTEST: //如果鼠标移动或单击 
                    base.WndProc(ref m);//调用基类的窗口过程——WndProc方法处理这个消息 
                    if (m.Result == (IntPtr)HTCLIENT)//如果返回的是HTCLIENT 
                    {
                        m.Result = (IntPtr)HTCAPTION;//把它改为HTCAPTION 
                        return;//直接返回退出方法 
                    }
                    break;
            }
            base.WndProc(ref m);//如果不是鼠标移动或单击消息就调用基类的窗口过程进行处理 
        }


        //用后面这个重写的方法有个问题~~~ 
        //你猜，如果你在窗体上双击鼠标，会发生什么？呵呵，窗体会最大化…… 
    }
}

