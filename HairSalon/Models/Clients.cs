using System;
using System.Collections.Generic;

namespace HairSalon.Models
{
	public class Client
	{
     private int _id;
     private int _stylistId;
     private string _name;
     private string _phone;
     private string _email;
    }

    public void SetId(int id) {_id = id;}
    public int GetId() {return _id;}

    public void SetStylistId(int stylistId) {_stylistId = stylistId;}
    public int GetStylistId() {return _stylistID;}

    public void SetName(string name) {_name = name;}
    public string GetName() {return name}

    public Client(string name, string phone, string email)
    {
      SetName(name);
      SetPhone(phone);
      SetEmail(email);
    }


	public static void ClearAll()
	{
	  Query clearClients = new Clients("DELETE FROM clients");
      clearClients.Execute();
	}

}