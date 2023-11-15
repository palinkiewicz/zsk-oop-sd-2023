<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>User</title>
</head>
<body>
    <form action="showUser" method="get">
        <input type="text" name="firstName" placeholder="Podaj imię" value="{{ old("firstName") }}">
        @error("firstName")
            <p>{{ $message }}</p>
        @enderror
        <br><br>
        <input type="text" name="email" placeholder="Podaj email" value="{{ old("email") }}">
        @error("email")
            <p>{{ $message }}</p>
        @enderror
        <br><br>
        <input type="submit" value="Wyślij">
        <ol>
            @if ($errors->any())
                @foreach ($errors->all() as $error)
                    <li>{{$error}}</li>
                @endforeach
            @endif
        </ol>
    </form>
</body>
</html>