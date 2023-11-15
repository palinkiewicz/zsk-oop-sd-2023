<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use Illuminate\Support\Facades\DB;

class DBController extends Controller
{
    function showUserTable() {
        return DB::table('users')
            ->select('name', 'email')
            ->where('name', 'Jan')
            ->get();
    }
}
