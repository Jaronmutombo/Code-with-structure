using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

public class FeatureCollection

// TODO Problem 5 - ADD YOUR CODE HERE
// Create additional classes as necessary
{
    public Feature[] Features { get; set; }

}

public class Feature
{
    public Geometry Geometry { get; set; }
    public Properties Properties { get; set; }
}

public class Geometry
{
    public string Type { get; set; }
    public double[] Coordinates { get; set; }
}

public class Properties
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
}