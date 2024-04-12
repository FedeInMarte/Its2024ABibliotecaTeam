internal class User
    {
        internal string Id { get; set; }
        internal string Name { get; set; }
        internal string LastName { get; set; }
        internal int SubYear { get; set; }


        internal User(string id, string name, string lastName, int subYear)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.SubYear = subYear;
        }


        internal string Denominazione
        {
            get
            {
                return $"{this.Name} {this.LastName}";
            }
        }

    }
