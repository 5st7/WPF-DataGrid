using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_DataGrid
{
    class Human
    {
        public enum GenderEnum
        {
            None,
            Men,
            Women
        }

        /* 
         * DataGridに表示するデータ構造を決める
         * 今回は名前(String),性別(Gender),年齢(int)の3つを追加してみる
        */
        public class Person
        {
            public string Name { get; set; }
            //?をつけることでnullを許容するようにする(string型は最初からnull許容できるのでいらない)
            //ボタンから追加しないなら?マークを外してMainWindow.xamlに書いてあるCanUserAddRows = "false"をCanUserAddRows = "true"にする
            public GenderEnum? Gender { get; set; }
            public int? Age { get; set; }
        }
    }
}
