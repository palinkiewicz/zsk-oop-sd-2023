<?php

use App\Http\Controllers\ProfileController;
use Illuminate\Support\Facades\Route;

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

Route::get('/dashboard', function () {
    return view('dashboard');
})->middleware(['auth', 'verified'])->name('dashboard');

Route::middleware('auth')->group(function () {
    Route::get('/profile', [ProfileController::class, 'edit'])->name('profile.edit');
    Route::patch('/profile', [ProfileController::class, 'update'])->name('profile.update');
    Route::delete('/profile', [ProfileController::class, 'destroy'])->name('profile.destroy');
});

Route::get('/helloworld', function () {
    return "Hello world!";
});

Route::redirect('/', 'helloworld');

Route::get('/status', function() {
    return "Status: " . app("Illuminate\Http\Response") -> status();
});

Route::get('/address/{city}', function (string $city) {
    echo <<< ADDRESS
        Address: $city
    ADDRESS;
});

Route::get('/address/{city}/{street}', function (string $city, string $street) {
    echo <<< ADDRESS
        Address: $city, $street
    ADDRESS;
});

Route::get('/address/{city}/{street}/{zipCode}', function (string $city, string $street, int $zipCode) {
    $zipCode = substr($zipCode, 0, 2) . '-' . substr($zipCode, 2, 3);

    echo <<< ADDRESS
        Address: $city, $street $zipCode
    ADDRESS;
});

Route::get('/city/{city}/{name}', function (string $city, string $name) {
    return view('city', [
        'city' => $city,
        'name' => $name
    ]);
});


Route::get('/address2/{city}/{street?}/{zipCode?}', function (string $city, string $street = null, int $zipCode = null) {
    $zipCode = substr($zipCode, 0, 2) . '-' . substr($zipCode, 2, 3);

    echo <<< ADDRESS
        NULLABLE<br>
        Address: $city, $street $zipCode
    ADDRESS;
});

Route::redirect('/cityData/{city}/{street?}/{zipCode?}', '/address2/{city}/{street?}/{zipCode?}');

require __DIR__.'/auth.php';
