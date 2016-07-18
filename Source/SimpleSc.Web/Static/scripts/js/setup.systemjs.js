System.config({
	defaultJSExtension: true,
	map: {
		app: 'static/scripts/js',
		rxjs: 'static/scripts/vendor/ang/rxjs',
		angular2: 'static/scripts/vendor/ang/angular2',
		'symbol-observable': 'static/scripts/vendor/ang/symbol-observable'
	},
	packages: {
		app: {
			defaultExtension: 'js',
			format: 'register'
		},
		rxjs: {
			defaultExtension: 'js',
			format: 'cjs'
		}
		,
		angular2: {
			defaultExtension: 'js',
			format: 'cjs'
		},
		'symbol-observable':
			{
				defaultExtension: 'js',
				main: 'index.js'
			}
	}
});

System.import('app/boot').then(null, console.error.bind(console));