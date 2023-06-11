using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCoffee
{
    internal static class DB
    {
        static void main()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=192.168.0.5;Port=3306;Database=cafe_db;Uid=newuser;Pwd=1q2w3e4r!"))
            {
                
                try//예외 처리
                {
                    connection.Open();
                    Console.WriteLine("성공성공성공성공성공성공성공성공성공성공성공성공성공성공성공성공성공성공성공성공");

                    // 만약에 내가처리한 Mysql에 정상적으로 들어갔다면 메세지를 보여주라는 뜻이다

                }
                catch (Exception ex)
                {
                    Console.WriteLine("실패");
                    Console.WriteLine(ex.ToString());
                }

            }
        }
    }
}
