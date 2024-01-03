<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>User</title>
</head>
<body>
    {{ print_r($user) }}
    {{ print_r($user['hobbies']) }}
    <p>
        Imię i nazwisko: {{ $user['firstName'] }} {{ $user['lastName'] }}
    </p>
    <p>
        Miasto: {{ $user['city'] }}
    </p>
    <p>
        Hobby:
        <ul>
            @foreach ($user['hobbies'] as $hobby)
                <li>{{ $hobby }}</li>
            @endforeach
        </ul>
    </p>
</body>
</html>