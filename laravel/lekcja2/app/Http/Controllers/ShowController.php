<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class ShowController extends Controller
{
    public function show() {
        return 'ME ime show controller';
    }

    public function showFirstName() {
        $data = [
            'firstName' => 'John',
            'lastName' => 'Smith',
            'city' => 'New York City'
        ];
        return 'Imię: ' . $data['firstName'];
    }

    public function showData() {
        $data = [
            'firstName' => 'John',
            'lastName' => 'Smith',
            'city' => 'New York City'
        ];
        return view('data', $data);
    }
}
