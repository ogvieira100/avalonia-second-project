using System;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Npgsql; // Para PostgreSQL
public interface IDatabaseFactory
{
    IDbConnection CreateConnection();
    IDbCommand CreateCommand();
    IDataReader ExecuteReader(IDbCommand command);
    int ExecuteNonQuery(IDbCommand command);
    object ExecuteScalar(IDbCommand command);
}

public class SqlServerFactory : IDatabaseFactory
{
    private readonly string _connectionString;

    public SqlServerFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IDbConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }

    public IDbCommand CreateCommand()
    {
        return new SqlCommand();
    }

    public IDataReader ExecuteReader(IDbCommand command)
    {
        return command.ExecuteReader();
    }

    public int ExecuteNonQuery(IDbCommand command)
    {
        return command.ExecuteNonQuery();
    }

    public object ExecuteScalar(IDbCommand command)
    {
        return command.ExecuteScalar();
    }
}

// Factory para MySQL
public class MySqlFactory : IDatabaseFactory
{
    private readonly string _connectionString;

    public MySqlFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IDbConnection CreateConnection()
    {
        return new MySqlConnection(_connectionString);
    }

    public IDbCommand CreateCommand()
    {
        return new MySqlCommand();
    }

    public IDataReader ExecuteReader(IDbCommand command)
    {
        return command.ExecuteReader();
    }

    public int ExecuteNonQuery(IDbCommand command)
    {
        return command.ExecuteNonQuery();
    }

    public object ExecuteScalar(IDbCommand command)
    {
        return command.ExecuteScalar();
    }
}

// Factory para PostgreSQL
public class PostgreSqlFactory : IDatabaseFactory
{
    private readonly string _connectionString;

    public PostgreSqlFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IDbConnection CreateConnection()
    {
        return new NpgsqlConnection(_connectionString);
    }

    public IDbCommand CreateCommand()
    {
        return new NpgsqlCommand();
    }

    public IDataReader ExecuteReader(IDbCommand command)
    {
        return command.ExecuteReader();
    }

    public int ExecuteNonQuery(IDbCommand command)
    {
        return command.ExecuteNonQuery();
    }

    public object ExecuteScalar(IDbCommand command)
    {
        return command.ExecuteScalar();
    }
}