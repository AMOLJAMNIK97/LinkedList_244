﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            //list.Addnote(56);
            //list.Addnote(30);
            //list.Addnote(70);
            //list.Display();


            list.Addreverse(70);
            list.Addreverse(30);
            list.Addreverse(56);
            list.Display();


        }
    }
}