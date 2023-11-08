namespace AgenciaViajes.Application.Features.ReservationFeatures.Command.CreateReservation
{
    public interface ICreateReservationCommand
    {
        Task Execute(CreateReservationRequest model);
    }
}
