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
    public string GetEmail() {return _email;}

    public Client(string name, string phone, string email)
    {
      SetName(name);
      SetPhone(phone);
      SetEmail(email);
    }

    public void Save(int stylistId)
    {
    Query addClient = new Query("INSERT INTO clients VALUES(NULL, @StylistId, @Name, @Phone, @Email)"); 
    addClient.AddParameter("@StylistId", stylistId.ToString());
    addClinet.AddParameter("@Name", GetName());
    addClinent.AddParameter("@Phone", GetPhone());
    addClient.AddParameter("@Email", GetEmail());
    addClient.Execute();
    SetId((int)addClient.GetCommand().LastInsertedId);
    }

    public static Client Find(int id)
    {
      Query findClinent = new Query("SELECT * FROM clients WHERE client_id = @Id");
      findClient.AddParameter("@Id", id.ToString());
      var rdr = findClient.Read();
      int stylistId = 0;
      string name = "";
      string phone = "";
      string email = "";

        while (rdr.Read())
        {
          stylistId = rdr.GetInt32(1);
          name = rdr.GetString(2); 
          phone = rdr.GetPhone(3);
          email = rdr.GetEmail(4);
        }

        Client found = new Client(name, phone, email);
        found.SetStylistId(stylistId);
        found.SetId(id);
        return found;
     }

    public static List<Client> GetAll()
    {
      List<Client> allClients = new List<Client> {};
      Query getAllClients = new Query("SELECT * FROM clients");
      var rdr = getAllClients.Read();
      
      while (rdr.Read())
      {
        int stylistId = rdr.GetString32(1);
        string name = rdr.GetName(2);
        string phone = rdr.GetPhone(3);
        string email = rdr.GetEmail(4);
        Client client = new Client(name, phone, email);
        client.SetId(rdr.GetInt32(0));

        allClients.Add(client);
      }
      return allClients;
     }

    public void Update()
    {
      Query updateClient = new Query ("UPDATE clients SET name = @Name, phone = @Phone, email = @Email");
      updateClient.AddParameter("@ClientId", GetId().ToString());
      updateClient.AddParameter("@Name", GetName());
      updateClient.AddParameter("@Phone", GetPhone());
      updateClient.AddParameter("@Email", GetEmail());
      updateClient.Execute();
    }

   public static void ClearAll()
    {
      Query clearClients = new Query("DELETE FROM clients");
      clearClients.Execute();
    }
    
  }
}