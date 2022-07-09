        using var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var groups = connection.Query<CountStudentGroupByAttribute>("SELECT city AS attributeName, COUNT(registration) AS studentNumber FROM Students GROUP BY city;").ToList();

        return groups;
