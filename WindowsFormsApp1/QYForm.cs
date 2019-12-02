using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace TJ_Tutors_Management_System
{
    public partial class QYForm : Form
    {
        Bitmap bit;//字段
        Bitmap bit2;//字段
        Bitmap copy;//字段
        int x;//字段
        int y;//字段
        int xx;//字段
        int yy;//字段
        Pen pen = new Pen(Color.Red, 2);//定义用于绘制直线和曲线的对象。 用指定的 颜色 和 宽度 初始化
        Rectangle rect = new Rectangle();//存储一组整数，共四个，表示一个矩形的位置和大小
        Graphics g2;//字段
        string tpName = "qy";//图片保存名字
        Main F1;//字段
        public QYForm(Main zct)//zct 传递过来的 主窗体
        {
            InitializeComponent();
            F1 = zct;//将zct 赋值给 F1，引用赋值。都指向 主窗体。
        }
        private void QYForm_Load(object sender, EventArgs e)//窗体 默认加载 事件
        {
            WindowState = FormWindowState.Minimized;//最小化窗体
            Thread.Sleep(200);//延迟200毫秒
            FormBorderStyle = FormBorderStyle.None;//指定窗体的边框样式。 无样式
            this.Cursor = Cursors.Cross;//鼠标为 十字线光标.
            Rectangle rect = new Rectangle();
            rect = Screen.GetWorkingArea(this);
            bit = new Bitmap(rect.Width, rect.Height);//获取桌面图
            Graphics g = Graphics.FromImage(bit);//把图画出来
            g.CopyFromScreen(0, 0, 0, 0, new Size(rect.Width, rect.Height));//绘制图片，g.CopyFromScreen(起点的屏幕坐标X,起点的屏幕坐标Y,0,0,new Size(窗体的宽度,窗体的高度))
            pictureBox1.Image = bit;//将图片显示在 pictureBox1 控件上
            tpName += DateTime.Now.ToString("yyyyMMddHHmmss");//获取当前时间为 文件名
            WindowState = FormWindowState.Maximized;//最大化当前窗体，这时候 pictureBox 也自适应最大化显示刚才截取的全屏图片，以备 区域截图使用。
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)// 图片框 移动鼠标 事件
        {
            if (e.Button == MouseButtons.Right)//是否按下鼠标右键
            {
                this.Dispose();//是否资源
                this.Close();//关闭当前窗体
                F1.Show();//显示主窗体
                F1.Activate();//激活主窗体，并给予焦点。    按下右键相当于 退出 区域截图。
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) //图片框  鼠标按下 事件， 就是 区域截图 开始 鼠标按下的坐标
        {
            x = Math.Abs(e.X);// e.X 获取鼠标在产生鼠标事件时的 x 坐标。绝对值     区域截图 开始 鼠标按下的X坐标
            y = Math.Abs(e.Y);// e.Y 获取鼠标在产生鼠标事件时的 y 坐标。绝对值     区域截图 开始 鼠标按下的Y坐标
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) //图片框 鼠标 移过 事件
        {
            if (e.Button == MouseButtons.Left)//判断 鼠标 是否 按下左键  这是 拖拽出 区域截图的 时候最后松开鼠标的 坐标
            {
                xx = Math.Abs(e.X);//最后的X坐标
                yy = Math.Abs(e.Y);//最后的Y坐标
                Graphics g = pictureBox1.CreateGraphics();//为控件创建 System.Drawing.Graphics。
                rect = new Rectangle(x, y, xx - x, yy - y);//  Rectangle(起始x, 起始y, 截取宽度xx - x, 截取高度yy - y) 最后坐标xx 减去 起始x 得到 宽度。      用指定的位置和大小初始化 System.Drawing.Rectangle 类的新实例。
                Refresh();//强制控件使其工作区无效并立即重绘自己和任何子控件。
                g.DrawRectangle(pen, rect);//绘制由 System.Drawing.Rectangle 结构指定的矩形。
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) //图片框 鼠标 释放按钮是发生
        {
            if (e.Button == MouseButtons.Left)//判断 鼠标 是否 按下左键
            {
                copy = (Bitmap)bit.Clone();//创建此 System.Drawing.Image 的一个精确副本。
                if (rect.Width == 0 || rect.Height == 0) //判断 宽度 或高度 是否为0
                {
                    MessageBox.Show("选取的区域无效!\r\n请持续按下鼠标左键绘制你要截取的区域.", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);//提示
                    this.Dispose();//释放资源
                    this.Close();//关闭窗体
                    F1.Show();//显示 主窗体
                    F1.Activate();//主窗体激活 并且给予 焦点
                }
                else//否则
                {
                    bit2 = new Bitmap(rect.Width, rect.Height);// 用指定的大小初始化 System.Drawing.Bitmap 类的新实例。
                    g2 = Graphics.FromImage(bit2);//从指定的 Image 创建新的 Graphics。
                    g2.DrawImage(copy, new Rectangle(0, 0, rect.Width, rect.Height), rect, GraphicsUnit.Pixel);//在指定位置并且按指定大小绘制指定的 System.Drawing.Image 的指定部分。
                    pictureBox1.Image = bit2;//在 图片框 控件 显示 截取后的 图片
                    Clipboard.SetImage(bit2);//将图片添加到 剪切板中
                    if (MessageBox.Show("截图完成!已保存到剪切板中.", "截图完成", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)// 判断是否点击 OK按钮
                    {
                        this.Dispose();//释放资源
                        this.Close();//关闭窗体
                        F1.Show();//显示 主窗体
                        F1.Activate();//主窗体激活 并且给予 焦点
                    }
                }
            }

        }


    }
}
