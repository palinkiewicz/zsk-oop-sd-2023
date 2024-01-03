<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;
use Illuminate\Support\Facades\Hash;

class DBController extends Controller
{
    function showUserTable() {
        return DB::table('users')
            ->select('name', 'email')
            ->where('name', 'Jan')
            ->get();
    }

    function addSampleUser() {
        DB::table('users')
            ->insert([
                'name' => 'Krystyna',
                'email' => 'krystyna@o2.pl',
                'password' => Hash::make('krystyna123')
            ]);
        return "Dodano.";
    }
}
