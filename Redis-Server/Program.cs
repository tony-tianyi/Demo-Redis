using ServiceStack.Redis;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Redis_Server
{
   public class Program
    {
        //static void Main(string[] args)
        //{
            //RedisClient client = new RedisClient("127.0.0.1", 6379);
            //client.FlushAll();
            ////增加Key，查询
            //client.Add<string>("RedisKeyAdd", "测试字符串Add", DateTime.Now.AddMilliseconds(3000));
            //Console.WriteLine("键：RedisKeyAdd;值：" + client.Get<string>("RedisKeyAdd"));

            ////删除Key，查询
            //client.Remove("RedisKeyAdd");
            //if (!client.ContainsKey("RedisKeyAdd"))
            //{
            //    Console.WriteLine("键：RedisKeyAdd;值：被删除");
            //}

            ////设置Key，查询
            //client.Set<string>("RedisKeySet", "测试字符串Set", DateTime.Now.AddMilliseconds(3000));
            //Console.WriteLine("键：RedisKeySet;值：" + client.Get<string>("RedisKeySet"));

            ////过期，查询
            //Thread.Sleep(4000);
            //if (!client.ContainsKey("RedisKeySet"))
            //{
            //    Console.WriteLine("键：RedisKeySet,值:已过期");
            //}
            //Console.ReadLine();


            //using (var redis = ConnectionMultiplexer.Connect("127.0.0.1"))
            //{
            //    DateTime? date = null;
            //    写入
            //    var db = redis.GetDatabase();
            //    db.StringSet("key", "123456");
            //    设置过期日期
            //    if (date != null)
            //    {
            //        DateTime time = DateTime.Now.AddSeconds(20);
            //        db.KeyExpire("key", time);
            //    }
            //    var result = db.StringGet("key");
            //}
        //    string key = "key";
        //    using (var redis = ConnectionMultiplexer.Connect("Localhost"))
        //    {
        //        //读取
        //        var db = redis.GetDatabase();
        //        var result = db.StringGet(key);
        //        Console.WriteLine(result + "键：RedisKeySet,值:已过期");
        //    }
        //}
    }
}
