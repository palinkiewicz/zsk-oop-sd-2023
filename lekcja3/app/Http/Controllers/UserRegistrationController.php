<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserRegistrationController extends Controller
{
    function showUser(Request $req) {
        $req->validate([
            'first_name' => 'required | min:5 | max:32',
            'last_name' => 'required | min:3 | max:32',
            'email' => 'required | email | min:2 | max:128'
        ]);
    }
}
