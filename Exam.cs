using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oopsProject1
{
    public class Exam

    {
        string? _name;
        int? _maths;
        int? _phys;
        int? _chem;
        int? _total;
        double? _percntg;
        int? _fullmarks;

        public Exam()
        {
            Console.WriteLine("ENter Your Name");
            _name = Console.ReadLine();
            Console.WriteLine("Your your math marks");
            _maths = int.Parse(Console.ReadLine());
            Console.WriteLine("Your your phycs marks");
            _phys = int.Parse(Console.ReadLine());
            Console.WriteLine("Your your chem marks");
            _chem = int.Parse(Console.ReadLine());
          //  _fullmarks = 50;
          //  int marks = 300;
            _total = _maths + _chem + _phys;
            // _percntg = _total/100*_total;
            _percntg = _total / 3.0;
            Console.WriteLine("student total marks" + _total);
            Console.WriteLine("student percentage " + _percntg);
        }
        public bool result()
        {
            if (_percntg >= 80&& _percntg<=90)
            {
                Console.WriteLine("Grett you have first class"+_percntg);            }

            else if (_percntg >= 60 && _percntg <= 70)
            {
                Console.WriteLine("Grett you have second class" + _percntg);
            }
            else if (_percntg >= 50 && _percntg <= 60)
            {
                Console.WriteLine("Grett you have third class" + _percntg);
            }

            else if (_percntg >= 40 && _percntg <= 50)
            {
                Console.WriteLine("Grett you have passed class" + _percntg);
            }

            else
            {
                Console.WriteLine("You are failed");
            }
            return true;
        }
        public object? this[int Index]
        {
            get
            {
                if (Index == 1)
                    return _name;
                else if (Index == 2)
                    return _maths;
                else if (Index == 3)
                    return _phys;
                else if (Index == 4)
                    return _chem;
                else if (Index == 5)
                    return _total;
                else if (Index == 6)
                    return _percntg;
                else if (Index == 7)
                    return _fullmarks;

                else
                    return null;
            }
            set
            {
                if (Index == 1)
                {
                    _name = (string?)value;
                }
                else if (Index == 2)
                {
                    _maths = (int?)value;
                }
                else if (Index == 3)
                {
                    _phys = (int?)value;
                }
                else if (Index == 4)
                {
                    _chem = (int?)value;
                }
                else if (Index == 5)
                {
                    _total = (int?)value;
                }
                else if (Index == 6)
                {
                    _fullmarks = (int?)value;
                }
                else if (Index == 7)
                {
                    _percntg = (int?)value;
                }

            }









        }


        }
    }
