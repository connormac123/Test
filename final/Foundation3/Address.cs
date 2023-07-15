using System.Text;
using System.Collections.Generic;
using System;

public class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string StateOrProvince { get; set; }
    public string Country { get; set; }

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        StreetAddress = streetAddress;
        City = city;
        StateOrProvince = stateOrProvince;
        Country = country;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(StreetAddress);
        sb.AppendLine($"{City}, {StateOrProvince}");
        sb.AppendLine(Country);
        return sb.ToString();
    }
}
