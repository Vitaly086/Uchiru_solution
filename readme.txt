
task 6:

public class Instantiator<T> where T : new()
{
    public T Instance { get; }

    public Instantiator()
    {
        Instance = new T();
    }
}

task 9:
SELECT COUNT(*) count_students
FROM students  

SELECT COUNT(*) count_students
FROM students
WHERE name = 'Иван'

SELECT COUNT(*) count_students
FROM students
WHERE created_at > '2020-09-01'

SELECT MAX(child_count) max_child_count
FROM (
	SELECT parent_id, COUNT(*) child_count
	FROM students
	GROUP BY parent_id) child_count;