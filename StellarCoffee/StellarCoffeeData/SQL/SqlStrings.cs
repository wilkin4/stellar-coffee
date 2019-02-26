using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarCoffeeData.Migrations
{
    static class SqlStrings
    {
        internal static string UserSQL = @"
            INSERT INTO [Users]
            VALUES
            (
                'wilkin4',
                '123456',
                1
            );
        ";
    }
}
