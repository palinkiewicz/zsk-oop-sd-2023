<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class LoginController extends Controller
{
    public function logout() {
        // Logout user
        auth()->logout();
        // Redirect to homepage
        return redirect('/');
    }
}
