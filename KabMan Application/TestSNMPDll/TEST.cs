using System;
using System.Collections;
using SNMPDll;


namespace TestSNMPDll
{
	/// <summary>
	/// Summary description for Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{

            ////LOAD all the MIB found into the directory c:\windows\System32\****************
            //Mib myMib = new Mib();
            //Console.WriteLine("**************Loading MIB's files**************");
            //myMib.loadDirectoryMib(Environment.GetFolderPath(Environment.SpecialFolder.System));
            ////****************************************************************************


            ////**************DISPLAY THE loading MIB************************
            ////myMib.walk(@"c:/aaaaaaa.txt");
            ////*************************************************************


            ////*************INIT SNMP AGENT*********************
            SNMPAgent myAgent = new SNMPAgent("10.147.248.78","public","public");
            // //if you do that please active the snmp capabilities into your compture : "Add/remove windows component" - "Management and monitoring tools"

            ////************INIT SNMP OBJECT*********************
            SNMPObject myRequest = new SNMPObject("1.3.6.1.4.1.289.2.1.1.2.4.1.1.4.1");
            Console.WriteLine();
            Console.WriteLine("***************Make the request***************");
            //Console.WriteLine(String.Format("I am looking for the value : {0}", myRequest.getFullName()));
            Console.WriteLine(String.Format("My value is : {0}", myRequest.getSimpleValue(myAgent)));
            Console.WriteLine(String.Format("The type of my value is : {0}", myRequest.getType()));
            Console.WriteLine(String.Format("The description of my value is : {0}", myRequest.getDescription()));

			//**********SOME OTHER TEST**********************
            //testWalk();
            //testMultiGet();
            //testSet();
			Console.ReadLine();
		}


		static private void testMultiGet()
		{
			Console.WriteLine("test multi get");
			Console.WriteLine("--------------");

			//Add many request you want
			SNMPObject[] s = new SNMPObject[2];
			s[0] = new SNMPObject("1.3.6.1.2.1.1.5.0");
			s[1] = new SNMPObject("1.3.6.1.2.1.2.2.1.16.1");

			SNMPAgent a = new SNMPAgent("127.0.0.1","public","public");
			Hashtable ht = a.getValues(s);
			int i = 1;
			while (true)
			{
				if (!ht.Contains(i)) break;
				Console.WriteLine("oid : " + s[i-1].getOID());
				Console.WriteLine("value : " + (string)((Hashtable)ht[i])["value"]);
				Console.WriteLine("type : " + (string)((Hashtable)ht[i])["type"]);
				i++;
			}

			Console.WriteLine("");
			
		}

	

		static private void testWalk()
		{
			Console.WriteLine("test walk");
			Console.WriteLine("---------");

            SNMPObject s = new SNMPObject("1.3.6.1.4.1.289.2.1.1.2.4.1.1.4.1");
			//SNMPObject s = new SNMPObject("1");
			SNMPAgent a = new SNMPAgent("127.0.0.1","public","public");
			a.walk(s);
			Console.WriteLine("");
		}

		static private void testSet()
		{

			//This procedure will cause a error on your computer, because you cannot change the name of your computer by an SNMP request
			//But of course this will work on a CISCO switch for example
			SNMPAgent myAgent = new SNMPAgent("127.0.0.1","public","public");
			Console.WriteLine("test Set");
			Console.WriteLine("--------");

			Console.WriteLine("Read the value before the modification");
			SNMPObject s = new SNMPObject("1.3.6.1.2.1.1.5.0");
			Hashtable ht = s.getValue(myAgent);

			Console.WriteLine("oid : " + s.getOID());
			Console.WriteLine("value : " + (string)ht["value"]);
			Console.WriteLine("type : " + (string)ht["type"]);

			Console.WriteLine("");

			Console.WriteLine("Set the value");

			s = new SNMPObject("1.3.6.1.2.1.1.5.0");
			myAgent.setValue(s,SNMPDll.SNMPOIDType.OctetString,"DEV-SOFT-ONE");

			Console.WriteLine("");

			Console.WriteLine("Read the value after the modification");

			s = new SNMPObject("1.3.6.1.2.1.1.5.0");
			ht = s.getValue(myAgent);

			Console.WriteLine("oid : " + s.getOID());
			Console.WriteLine("value : " + (string)ht["value"]);
			Console.WriteLine("type : " + (string)ht["type"]);
			




		}
	}
}
