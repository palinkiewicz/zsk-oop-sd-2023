<?php

use Illuminate\Support\Facades\Route;
use \App\Http\Controllers\ArrayController;

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

Route::get('show_array', [ArrayController::class, 'show']);

Route::view('user_form', 'forms.user');

Route::get('submit_user', [\App\Http\Controllers\UserFormController::class, 'ShowUser']);

Route::view('user_register', 'forms.userregister');

Route::get('register_user', [\App\Http\Controllers\UserRegistrationController::class, 'showUser']);
