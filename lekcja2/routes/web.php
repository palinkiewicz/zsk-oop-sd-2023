<?php

use Illuminate\Support\Facades\Route;
use \App\Http\Controllers\ShowController;

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider and all of them will
| be assigned to the "web" middleware group. Make something great!
|
*/

Route::get('/logout', '\App\Http\Controllers\LoginController@logout');

Route::get('/', function () {
    return view('welcome');
});

Route::middleware([
    'auth:sanctum',
    config('jetstream.auth_session'),
    'verified',
])->group(function () {
    Route::get('/dashboard', function () {
        return view('dashboard');
    })->name('dashboard');
});

Route::get('/show', '\App\Http\Controllers\ShowController@show');
Route::get('/show2', [ShowController::class, 'show']);

Route::get('/showName', [ShowController::class, 'showFirstName']);

Route::get('/data', [\App\Http\Controllers\ShowController::class, 'showData']);