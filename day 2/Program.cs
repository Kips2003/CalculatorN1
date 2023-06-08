﻿
            /////////////////////////////////////////////////////////
            /////    Calculator : giorgi kiparoidze           ///////
            /////////////////////////////////////////////////////////

using System;

namespace myworld{
    class Myprogram{
        //kalkulatoris funcqcia
        public static int Calculator(int a, char b, int c){
            switch(b){
                case '+': a+=c;break;
                case '-': a-=c;break;
                case '*': a*=c;break;
                case '/': a/=c;break;
            }
            return a;
        }

        //operatoris gadamowmebis funqcia
        public static bool OperatorCheck(char a){
            if (a == '+' || a=='-' || a=='*' || a=='/')
            return true;
            else{
                Console.WriteLine("shemotanili operatori ar aris misagebi!");
                return false;
            }
        }

        public static void Main(string[] args){
            
            while(true){
                Console.WriteLine("Calculator");

                //shemovitanot pirveli cvladi
                string? userInput;
                int firstNumber;
                while(true){
                    Console.WriteLine("shemoitanet pirveli cvladi kalkulatoristvis :");
                    userInput = Console.ReadLine();
                    bool numberCheck = int.TryParse(userInput, out firstNumber);
            
                    //shemotanili cvladis gadamowmeba (aris tu ara ricxvi)
                    if(!numberCheck){
                        Console.WriteLine("shemotanili cvladi ar aris ricxvi");
                    }
                    else break;
                }
                while(true){
                    //operatoris shemotana
                    string? userInput1;
                    char oper;
                    while(true){
                        Console.WriteLine("shemoitanet operatori operaciistvis : ");
                        userInput1 = Console.ReadLine();
                        bool operatorCheck = char.TryParse(userInput1, out oper);

                        //shemotanili operatoris gadamowmeba
                        if(!operatorCheck && !OperatorCheck(oper)){
                            Console.WriteLine("shemotanili cvladi ar aris misagebi");
                        }
                        else break;
                    }

                    //shemovitanot meore  cvladi
                    string? userInput2;
                    int secondNumber;
                    while(true){
                        Console.WriteLine("shemoitanet meore cvladi kalkulatoristvis :");
                        userInput2 = Console.ReadLine();
                        bool numberCheck1 = int.TryParse(userInput2, out secondNumber);
            
                        //shemotanili cvladis gadamowmeba (aris tu ara ricxvi)
                        if(!numberCheck1){
                            Console.WriteLine("shemotanili cvladi ar aris ricxvi");
                        }
                        else break;
                    }



                    //string cvladi sadac shevinaxavs operaciebs
                    userInput = userInput + userInput1 + userInput2;
                    firstNumber = Calculator(firstNumber, oper, secondNumber);
                    
                    while(true){
                        Console.WriteLine("gsurt operaciis gagrdzeleba? (daweret ki an ara)");
                        string? gagrdzeleba = Console.ReadLine();
                        if(gagrdzeleba == "ki")break;
                        else if(gagrdzeleba == "ara"){
                            Console.WriteLine($"{userInput}={firstNumber}");
                            while(true){
                                Console.WriteLine("gsurt sxva operaciis shesruleba? (daweret ki an ara)");
                                string? otherOperation = Console.ReadLine();
                                if(otherOperation == "ki") break;
                                else if (otherOperation == "ara") return;
                                else{
                                    Console.WriteLine("pasuxi aradamakmayofilebelia!");
                                }
                            }
                        }
                        else{
                            Console.WriteLine("migebuli pasuxi ar sheesabameba pirobebs");
                        }
                    }
                }
            }    
        }
    }
}