namespace Creational_Builder.Domain.Model
{
    public class House
    {
        private List<object> _parts = new List<object>();

        public void Add(string part) 
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            string str = string.Empty;

            for (int i = 0; i < this._parts.Count; i++)
            {
                str += this._parts[i] + ", ";
            }

            str = str.Remove(str.Length - 2); //removendo ultimos caracteres ,c

            return "House parts: " + str + "\n";
        }
    }
}
