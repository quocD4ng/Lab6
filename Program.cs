using System;

namespace Bài1
{
    //  Khởi tạo lớp Window
    class Window
    {
        private int top;
        private int left;
        //  Attributes - thuộc tính trong lớp
        public int Top
        {
            get => top;
            set => top = value;
        }
        public int Left
        {
            get => left;
            set => left = value;
        }
        //  Constructor mặc định không tham số
        public Window()
        {

        }
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        //  Phương thức đáp ứng yêu cầu đề bài
        public virtual string DrawWindow()
        {
            return;
        }
    }
    class Button:Window
    {
        public override string DrawWindow()
        {
            return;
        }
    }
    class ListBox : Window
    {
        public string Content()
        {
            return;
        }
        public override string DrawWindow()
        {
            return;
        }
    }
    class Program
    {

    }
}