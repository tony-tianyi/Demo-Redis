using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redis_Server
{
    public class redis_run
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Redis写入缓存：wang");

            RedisCacheHelper.Add("hellow redis", "redis-test", DateTime.Now.AddDays(1));

            Console.WriteLine("Redis获取缓存：hellow redis");

            string str3 = RedisCacheHelper.Get<string>("hellow redis");

            Console.WriteLine(str3);

            RedisCacheHelper.Remove("wang");
            string str = RedisCacheHelper.Get<string>("nihao");
            Console.WriteLine(str == null ? "未找到" : str);


          

            Console.ReadKey();
        }
    }
}
