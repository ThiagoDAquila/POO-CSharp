using LocadoraVeiculos.Entities;

namespace LocadoraVeiculos.Services
{
    class RentalServices
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxServices _taxServices;

        public RentalServices(double pricePerHour, double pricePerDay, ITaxServices taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxServices = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxServices.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
