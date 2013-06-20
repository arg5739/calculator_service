using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    /**
 *This method performs the addition of two values
 *
 * @param       value1    it takes double
 * @param       value2    it takes double
 
 *
 * @return      It return the addtion of two number in double
 *
 */

    public double add(double value1, double value2)
    {
        return value1 + value2;
    }

    /**
    *This method performs the subtraction of tow values
    *
 * @param       value1    it takes double
 * @param       value2    it takes double
 
 *
 * @return      It return the subtraction of two number in double
 *
 */


    public double subtract(double value1, double value2)
    {
        return value1 - value2;
    }

    /**
 *This method performs the multiplication of two values
 *
 * @param       value1    it takes double
 * @param       value2    it takes double
 
 *
 * @return      It return the multiplication of two number in double
 *
 */

    public double multiple(double value1, double value2)
    {
        return value1 * value2;
    }
    /**
 *This method performs the division of two values
 *
 * @param       value1    it takes double
 * @param       value2    it takes double
 
 *
 * @return      It return the division of two number in double
 *
 */

    public double divide(double value1, double value2)
    {
        return value1 / value2;
    }
}
