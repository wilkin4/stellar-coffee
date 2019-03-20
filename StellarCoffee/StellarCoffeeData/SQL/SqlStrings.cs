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
                'Wilkin',
                'Vásquez',
                'wilkin4',
                '123456',
                1
            );
        ";

        internal static string ReceiptTypeSQL = @"
            INSERT INTO [ReceiptTypes]
            VALUES(
	            'Factura de Crédito Fiscal (Tipo 01)',
	            1
            )

            INSERT INTO [ReceiptTypes]
            VALUES(
	            'Factura de Consumo (Tipo 02)',
	            1
            )

            INSERT INTO [ReceiptTypes]
            VALUES(
	            'Notas de Débito (Tipo 03)',
	            1
            )

            INSERT INTO [ReceiptTypes]
            VALUES(
	            'Notas de Crédito (Tipo 04)',
	            1
            )

            INSERT INTO [ReceiptTypes]
            VALUES(
	            'Regímenes Especiales de Tributación (Tipo 14)',
	            1
            )

            INSERT INTO [ReceiptTypes]
            VALUES(
	            'Comprobantes Gubernamentales (Tipo​ 15)',
	            1
            )
        ";
    }
}
