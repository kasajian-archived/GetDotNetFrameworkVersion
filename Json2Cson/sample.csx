using System;
using System.Collections.Generic;
using System.Linq;

// {
//     "Releases": {
//         "378389": "4.5",
//         "378675": "4.5.1",
//         "378758": "4.5.1"
//     }
// }

dynamic x = new { Foo = 12, Bar = "twelve" };

dynamic obj = new Dictionary<string, dynamic> {
    ["Release"] = new Dictionary<string, dynamic> {
        ["378389"] = "4.5",
        ["378675"] = "4.5.1",
        ["378758"] = "4.5.1"
    },
    ["Preferred"] = new List<dynamic> {"378389", "378758"}
};

dynamic obj2 = 
new Dictionary<string, dynamic> {
    ["o"] = new List<dynamic> {
        new Dictionary<string, dynamic> {
            ["a"] = new List<dynamic> {
                1,
                2
            },
            ["b"] = new List<dynamic>(),
            ["c"] = new Dictionary<string, dynamic>()
        }
    }
};


Console.WriteLine("yo");