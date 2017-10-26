using System;

//Make sure you get rid of the namespace that is automatically generated here.
class Town
{
    //List all the columns of your table here in the same format as below.
    public string id { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public string version { get; set; }
    public int TownId { get; set; }
    public string TownName { get; set; }
    public float Latitude { get; set; }
    public float Altitude { get; set; }
    public float Longitude { get; set; }
    public float Size { get; set; }
    public string Symbol { get; set; }
    public bool deleted { get; set; }
}
