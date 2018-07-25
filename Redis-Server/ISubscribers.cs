using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redis_Server
{
   public class ISubscribers
    {
        //static void Main(string[] args)
        //{
        //    string host = "192.168.1.132";
        //    ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(host);
        //    ISubscriber db = redis.GetSubscriber();
        //    db.Subscribe("test", new Action<RedisChannel, RedisValue>((chan, msage) =>
        //    {
        //        Console.WriteLine("通道：" + chan);
        //        Console.WriteLine("消息内容：" + msage);
        //    }));
        //    Console.ReadLine();
        //}
    }
}
