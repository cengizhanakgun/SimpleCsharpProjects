// See https://aka.ms/new-console-template for more information


Double CPUtprt = 0;
System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher(@"root\WMI", "Select * From MSAcpi_ThermalZoneTemperature");
foreach (System.Management.ManagementObject mo in mos.Get())
{
    CPUtprt = Convert.ToDouble(Convert.ToDouble(mo.GetPropertyValue("CurrentTemperature").ToString()) - 2732) / 10;
    Console.WriteLine("CPU temp : " + CPUtprt.ToString() + " °C");
}
Console.ReadKey();