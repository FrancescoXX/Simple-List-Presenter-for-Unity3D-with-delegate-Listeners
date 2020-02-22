//Item Model
public class Item  {
    public int id { get; set; }
    public string name { get; set; }
    public int record { get; set; }

    public Item(int id, string name, int record) {
        this.id = id;
        this.name = name;
        this.record = record;
    }
}