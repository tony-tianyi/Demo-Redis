using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redis_Server
{
    class Subscriber
    {
        //static void Main(string[] args)
        //{
        //    string host = "192.168.1.132";
        //    ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(host);
        //    ISubscriber db = redis.GetSubscriber();//redis.GetDatabase(1)指定数据库1；如果不填写则默认为-1
        //    db.Publish("test", "123");
        //    string reader = "start end";
        //    while (reader != "exit")
        //    {
        //        reader = Console.ReadLine();
        //        db.Publish("test", reader);
        //    }
        //    Console.Read();
        //}

    }
}
