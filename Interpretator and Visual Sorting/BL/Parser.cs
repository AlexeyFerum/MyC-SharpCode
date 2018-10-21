using System;
using System.Drawing;

namespace BL
{
    public enum Operation
    {
        plus,
        minus,
        multiply,
        divide,
        none
    }

    public abstract class PNode
    {
        public abstract int Calculate();
        protected int value;
        public int Value
        {
            get { return Calculate(); }
        }
        public int x;
        public int y;
        public bool visit;
    }

    class NodeConst : PNode
    {
        public NodeConst(int value)
        {
            this.value = value;
        }
        public override int Calculate()
        {
            return value;
        }
    }

    class NodeOperation : PNode
    {
        public Operation type;
        public PNode left;
        public PNode right;

        public NodeOperation(Operation op, PNode left, PNode right)
        {
            this.left = left;
            this.right = right;
            this.type = op;
        }

        public override int Calculate()
        {
            int a = Convert.ToInt32(left.Calculate());
            int b = Convert.ToInt32(right.Calculate());
            switch (type)
            {
                case Operation.plus:
                    value = a + b;
                    return value;
                case Operation.minus:
                    value = a - b;
                    return value;
                case Operation.multiply:
                    value = a * b;
                    return value;
                case Operation.divide:
                    value = a / b;
                    return value;
                default: throw new NotImplementedException();
            }
        }
    }

    public class Parser
    {
        static char[] digits = { '0', '1', '2', '3', '4', '5',
                    '6', '7', '8', '9' };
        static char[] symbols = { '*', '/', '+', '-' };
        PNode top;
        PNode selected;
        int n = 0;
        const int step = 20;
        const int dh = 3;
        const int R = 15;
        Graphics g;
        public Bitmap bitmap;
        static Font myFont = new Font("Courier New", 12, FontStyle.Bold);

        public Parser(int width, int height)
        {
            top = null;
            bitmap = new Bitmap(width, height);
        }

        public Parser(int width, int height, ref string s)
        {
            top = null;
            bitmap = new Bitmap(width, height);
            Expression(ref s, out top);
            SetCoordinates();
        }
        
        public void Parse(ref string s)
        {
            n = 0;
            s = s.Trim();
            Expression(ref s, out top);
            SetCoordinates();
        }
        
        string Pop(ref string s, byte n)
        {
            string result = s.Substring(0, n);
            s = s.Substring(n);
            return result;
        } 
        
        bool Test(char ch, params char[] arr)
        {
            return Array.IndexOf(arr, ch) >= 0;
        }
        
        void Digit(ref string s, out PNode P)
        {
            string st = "";
            while (s.Length != 0 && Test(s[0], digits))
                st += Pop(ref s, 1);
            P = new NodeConst(Convert.ToInt32(st));
        }
        
        void Expression(ref string s, out PNode P)
        {
            if (s.Length != 0)
            {
                if (Test(s[0], digits))
                {
                    Digit(ref s, out P);
                }
                else
                    if (s[0] == '(')
                    {
                        Pop(ref s, 1);
                        Expression(ref s, out P);
                        if (s.Length == 0 || s.Length > 0 && s[0] != ')')
                            throw new ParserException(2);
                        Pop(ref s, 1);
                    }
                    else
                        switch (s[0])
                        {
                            case '*': throw new ParserException(3);
                            case '/': throw new ParserException(4);
                            default: throw new ParserException(8); 
                        }
                if (s.Length > 0 && !(Test(s[0], symbols) || s[0] == ')'))
                    throw new ParserException(8);
                while (s.Length > 0 && Test(s[0], symbols))
                {
                    string symbol = Pop(ref s, 1);
                    if (s.Length == 0)
                        switch (symbol)
                        {
                            case "*": throw new ParserException(3);
                            case "/": throw new ParserException(5); 
                            case "+": throw new ParserException(6); 
                            case "-": throw new ParserException(7); 
                        }
                    PNode P2;
                    Expression(ref s, out P2);
                    PNode P1 = P;

                    Operation op = Operation.none;
                    switch (symbol)
                    {
                        case "*": op = Operation.multiply; break;
                        case "/": op = Operation.divide; break;
                        case "+": op = Operation.plus; break;
                        case "-": op = Operation.minus; break;
                    }
                    P = new NodeOperation(op, P1, P2);
                    n++;
                }
            }
            else throw new ParserException(1);
        }
        
        public string Result()
        {
            if (top != null)
                return Convert.ToString(top.Value);
            else throw new TreeEmptyException();
        }
        
        public void Shift(int dx, int dy)
        {
            ShiftNode(selected, selected.x - dx, selected.y - dy);
        }
        void ShiftNode(PNode p, int dx, int dy)
        {
            p.x -= dx; p.y -= dy;
            if ((p is NodeOperation) && ((p as NodeOperation).left != null))
                ShiftNode((p as NodeOperation).left, dx, dy);
            if ((p is NodeOperation) && ((p as NodeOperation).right != null))
                ShiftNode((p as NodeOperation).right, dx, dy);
        }
        
        public bool FindCoordinates(int x, int y)
        {
            if (top != null)
                selected = FindNode(top, x, y);
            return selected != null;
        }

        PNode FindNode(PNode p, int x, int y)
        {
            PNode result = null;
            if (p == null)
                return result;
            if (((p.x - x) * (p.x - x) + (p.y - y) * (p.y - y)) <= 10 * R)
                result = p;
            else
            {
                if ((p is NodeOperation) && ((p as NodeOperation).left != null))
                    result = FindNode((p as NodeOperation).left, x, y);
                if ((result == null) && (p is NodeOperation) && ((p as NodeOperation).right != null))
                    result = FindNode((p as NodeOperation).right, x, y);
            }
            return result;
        }

        public void RecolorSelected()
        {
            if (selected != null)
                selected.visit = true;
        }
        
        public void Draw(int w, int h)
        {
            if (top != null)
            {
                if (bitmap != null)
                    bitmap.Dispose();
                bitmap = new Bitmap(w, h);
                Draw();
            }
        }

        void Draw()
        {
            using (g = Graphics.FromImage(bitmap))
            {
                g.Clear(Color.White);
                DrawNode(top);
            }
        }

        void DrawNode(PNode p)
        {
            if ((p is NodeOperation) && ((p as NodeOperation).left != null))
                g.DrawLine(Pens.Black, p.x, p.y, (p as NodeOperation).left.x, (p as NodeOperation).left.y);
            if ((p is NodeOperation) && ((p as NodeOperation).right != null))
                g.DrawLine(Pens.Black, p.x, p.y, (p as NodeOperation).right.x, (p as NodeOperation).right.y);

            if (p.visit == false)
                g.FillEllipse(Brushes.LightBlue, p.x - R, p.y - R, 2 * R, 2 * R);
            else
                g.FillEllipse(Brushes.CornflowerBlue, p.x - R, p.y - R, 2 * R, 2 * R);
            g.DrawEllipse(Pens.Black, p.x - R, p.y - R, 2 * R, 2 * R);
            string s = "";
            if (p is NodeOperation)
                switch ((p as NodeOperation).type)
                {
                    case Operation.multiply: s = "*"; break;
                    case Operation.divide: s = "/"; break;
                    case Operation.plus: s = "+"; break;
                    case Operation.minus: s = "-"; break;
                }
            else
                s = Convert.ToString(p.Value);

            SizeF size = g.MeasureString(s, myFont);
            g.DrawString(s, myFont, Brushes.Black,
                p.x - size.Width / 2,
                p.y - size.Height / 2);

            if ((p is NodeOperation) && ((p as NodeOperation).left != null))
                DrawNode((p as NodeOperation).left);
            if ((p is NodeOperation) && ((p as NodeOperation).right != null))
                DrawNode((p as NodeOperation).right);
        }
        
        public void DeSelect()
        {
            if (top != null) DeSelectNode(top);
        }

        void DeSelectNode(PNode p)
        {
            if (p != null)
            {
                if (p is NodeOperation)
                    DeSelectNode((p as NodeOperation).left);
                p.visit = false;
                if (p is NodeOperation)
                    DeSelectNode((p as NodeOperation).right);
            }
        }
        
        public void SetCoordinates()
        {
            if (top != null)
                Set(top, bitmap.Width / 2, 40, n/2);
        }

        void Set(PNode p, int x, int y, int i)
        {
            p.x = x; p.y = y;
            if ((p is NodeOperation) && ((p as NodeOperation).left != null))
                Set((p as NodeOperation).left, x - (int)Math.Pow(2, i) * step, y + dh * step, i -1);
            if ((p is NodeOperation) && ((p as NodeOperation).right != null))
                Set((p as NodeOperation).right, x + (int)Math.Pow(2, i) * step, y + dh * step, i - 1);
        }

        public void Clear()
        {
            n = 0;
            top = null;
            selected = null;
        }
    }
}
