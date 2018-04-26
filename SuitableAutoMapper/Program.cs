using System;
using SuitableAutoMapper;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var suitableMapper = new SuitableMapper();
            var model1 = new Test1();
            var model2 = new Test2();
            var test = suitableMapper.Map<Test1, Test2>(model1, model2);
        }
    }

    public class Test1
    {
        public Test1()
        {
            this.hoge1 = "TEST1";
            this.hoge2 = 1;
            this.hoge3 = true;
            this.hoge4 = new Hoge(){ hoge1 = "OK!"};
        }
        public string hoge1 { get; set; }
        public int hoge2 { get; set; }
        public bool hoge3 { get; set; }
        
        public Hoge hoge4 { get; set; }
    }

    public class Test2
    {
        public Test2()
        {
            this.hoge1 = "TEST2";
            this.hoge2 = 5;
            this.hoge3 = 10;
            this.hoge4 = new Hoge();
        }
        public string hoge1 { get; set; }
        public int hoge2 { get; set; }
        public int hoge3 { get; set; }

        public Hoge hoge4 { get; set; }
    }
    public class Hoge
    {
        public string hoge1 { get; set; }
    }
}
