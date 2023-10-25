<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ArrayController extends Controller
{
    public function show() {
        $user = [
            'firstName' => 'Janusz',
            'lastName' => 'Smith',
            'city' => 'Poznań',
            'hobbies' => [
                'hiking',
                'fishing',
                'surfing',
                'making money'
            ]
        ];
        return view('show_user', ['user' => $user]);
    }
}
