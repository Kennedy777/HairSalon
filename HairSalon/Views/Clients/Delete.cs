<h2>Are you sure you want to delete @Model["client"].GetName() from client list?</h2>

<form action='/stylists/@Model["stylist"].GetId()/clients/@Model["client"].GetId()/deleted' method='post'>
    <button type='submit'>Delete</button>
</form>
<form action='/stylists/@Model["stylist"].GetId()'>
    <button type='submit'>Cancel</button>
</form>