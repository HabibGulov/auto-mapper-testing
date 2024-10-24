public interface IUserRepository
{
    PaginationResponse<IEnumerable<ReadUserDTO>> GetAllUsers(UserFilter userFilter);
    ReadUserDTO? GetUserById(int id);
    bool CreateUser(CreateUserDTO createUserDTO);  
    bool DeleteUser(int id);
    bool UpdateUser(UpdateUserDTO updateUserDTO);
}