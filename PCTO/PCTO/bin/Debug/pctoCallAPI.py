import requests


via = input('inserisci via: ')
viavia = via.replace(" ", '%20')

print(viavia)
response = requests.get('http://api.positionstack.com/v1/forward?access_key=b604e10883f69e0ea57f2e71c3c2f0d9&query={}'.format(viavia))



data = response.json()

print(data)

print(data['data'][0]['latitude'], data['data'][0]['longitude'])