using System;
using System.Collections.Generic;

namespace HairSalon.Models
{
	public class Client
	{
    private int _id;
    public void SetId(int id) {_id=id;}
    public void GetId(){return _id}

    private int _stylistId;
    public void SetStylistId(int stylistId) {_stylistId = stylistId;}
    public int GetStylistId() {return _stylistId;}

    private string _name;
    public void SetName(string name) {_name = name;}
    public string GetName() {return _name;}

    private string _phone;
    public void SetPhone(string phone) {_phone = phone;}
    public string GetPhone() {return _phone;}

    private string _email;
    public void SetEmail(string email) {_email = email;}
    public s

    public Client(string name, string phone, string email)
    {
      SetName(name);
      SetPhone(phone);
      SetEmail(email);
    }

    public static void ClearAll()
    {
      Query clearClients = new Query("DELETE FROM clients");
      clearClients.Execute();
    }

    public void Save(int stylistId)
    {
    Query addClient = new Query("INSERT INTO clients VALUES(NULL, @StylistId, @Name, @Phone, @Email)"); 
    addClient.AddParameter("@StylistId", stylistId.ToString());
    addClinet.AddParameter("@Name", GetName());
    addClinent.AddParameter("@Phone", GetPhone());
    addClient.AddParameter("@Email", GetEmail());
    
    }

  	public static void ClearAll()
  	{
	  Query clearClients = new Clients("DELETE FROM clients");
      clearClients.Execute();
  	}

}