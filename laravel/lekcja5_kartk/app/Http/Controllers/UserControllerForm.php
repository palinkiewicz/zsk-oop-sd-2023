<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserControllerForm extends Controller
{
    function show(Request $req) {
        $req->validate([
            'firstName' => 'required | min:2 | max:10',
            'email' => 'required | min:5 | max:50 | email'
        ],
        [
            'firstName.required' => 'Pole :attribute jest wymagane',
            'firstName.min' => 'Pole :attribute musi mieć minimum :min znaków',
            'firstName.max' => 'Pole :attribute musi mieć maximum :max znaków',

            'email.required' => 'Pole :attribute jest wymagane',
            'email.min' => 'Pole :attribute musi mieć minimum :min znaków',
            'email.max' => 'Pole :attribute musi mieć maximum :max znaków',
            'email.email' => 'Pole :attribute musi być typu email'
        ]);

        $firstName = $req->input("firstName");
        $email = $req->input("email");

        return "
            Imię: $firstName <br> Email: $email
        ";
    }
}
