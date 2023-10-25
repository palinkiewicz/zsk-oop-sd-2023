<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;

class UserFormController extends Controller
{
    public function ShowUser(Request $req) {
        print_r($req->input());
        echo '<br>';
        echo $req->input('firstName') . '<br>';
        echo $req->input('undefined') . '<br>';
        echo $req->path() . '<br>';
        echo $req->url() . '<br>';
        echo $req->method() . '<br>';
        print_r($req->all());
        echo '<br>';

        $dataUser = [
            'firstName' => $req->input('firstName'),
            'lastName' => $req->input('lastName'),
            'city' => $req->input('city'),
            'hobbies' => $req->input('hobbies') ? explode(',', $req->input('hobbies')) : []
        ];

        print_r($dataUser);
        echo '<br>';

        return app('\App\Http\Controllers\ArrayController')->show($dataUser);
    }
}
