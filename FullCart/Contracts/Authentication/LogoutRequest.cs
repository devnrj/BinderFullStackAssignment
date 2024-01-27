namespace FullCart.Contracts.Authentication;

public record LogoutRequest(
    string Email,
    string Password
);