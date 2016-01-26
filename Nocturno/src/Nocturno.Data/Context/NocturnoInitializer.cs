using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Nocturno.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Nocturno.Data.Context
{
    public class NocturnoInitializer : IDbInitializer
    {
        private readonly IDbContext _db;
        private readonly IHostingEnvironment _environment;
        private readonly UserManager<ApplicationUser> _userManager;

        public NocturnoInitializer(
            IDbContext db,
            IHostingEnvironment environment,
            UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _environment = environment;
            _userManager = userManager;
        }

        public async void InitializeDatabaseAsync()
        {
            if (!_db.Settings.Any())
            {
                var settings = new List<Setting>
                {
                    new Setting {Name = "Site name", Value = "Nocturno CMS Site"},
                    new Setting {Name = "Site theme", Value = "default.css"},
                    new Setting {Name = "Site owner", Value = "Patryk Lotzwi"},
                    new Setting {Name= "E-mail", Value = "p.lotzwi@outlook.com"}
                };
                _db.Settings.AddRange(settings);
                _db.SaveChanges();
            }

            //if (!_db.Set<ApplicationUser>().Any())
            //{
            //    string name = "p.lotzwi@nocturno.cloud";
            //    string password = "Q!e3t5U&";
            //    var user = new ApplicationUser
            //    {
            //        UserName = name,
            //        Email = name,
            //    };

            //    await _userManager.CreateAsync(user, password);
            //}

            #region Icons

            if (!_db.Icons.Any())
            {
                var icons = new List<Icon>
                {
                    new Icon { Name = "fa-adjust" },
                    new Icon { Name = "fa-anchor" },
                    new Icon { Name = "fa-archive" },
                    new Icon { Name = "fa-area-chart" },
                    new Icon { Name = "fa-arrows" },
                    new Icon { Name = "fa-arrows-h" },
                    new Icon { Name = "fa-arrows-v" },
                    new Icon { Name = "fa-asterisk" },
                    new Icon { Name = "fa-at" },
                    new Icon { Name = "fa-automobile" },
                    new Icon { Name = "fa-balance-scale" },
                    new Icon { Name = "fa-ban" },
                    new Icon { Name = "fa-bank" },
                    new Icon { Name = "fa-bar-chart" },
                    new Icon { Name = "fa-bar-chart-o" },
                    new Icon { Name = "fa-barcode" },
                    new Icon { Name = "fa-bars" },
                    new Icon { Name = "fa-battery-0" },
                    new Icon { Name = "fa-battery-1" },
                    new Icon { Name = "fa-battery-2" },
                    new Icon { Name = "fa-battery-3" },
                    new Icon { Name = "fa-battery-4" },
                    new Icon { Name = "fa-battery-empty" },
                    new Icon { Name = "fa-battery-full" },
                    new Icon { Name = "fa-battery-half" },
                    new Icon { Name = "fa-battery-quarter" },
                    new Icon { Name = "fa-battery-three-quarters" },
                    new Icon { Name = "fa-bed" },
                    new Icon { Name = "fa-beer" },
                    new Icon { Name = "fa-bell" },
                    new Icon { Name = "fa-bell-o" },
                    new Icon { Name = "fa-bell-slash" },
                    new Icon { Name = "fa-bell-slash-o" },
                    new Icon { Name = "fa-bicycle" },
                    new Icon { Name = "fa-binoculars" },
                    new Icon { Name = "fa-birthday-cake" },
                    new Icon { Name = "fa-bluetooth" },
                    new Icon { Name = "fa-bluetooth-b" },
                    new Icon { Name = "fa-bolt" },
                    new Icon { Name = "fa-bomb" },
                    new Icon { Name = "fa-book" },
                    new Icon { Name = "fa-bookmark" },
                    new Icon { Name = "fa-bookmark-o" },
                    new Icon { Name = "fa-briefcase" },
                    new Icon { Name = "fa-bug" },
                    new Icon { Name = "fa-building" },
                    new Icon { Name = "fa-building-o" },
                    new Icon { Name = "fa-bullhorn" },
                    new Icon { Name = "fa-bullseye" },
                    new Icon { Name = "fa-bus" },
                    new Icon { Name = "fa-cab" },
                    new Icon { Name = "fa-calculator" },
                    new Icon { Name = "fa-calendar" },
                    new Icon { Name = "fa-calendar-check-o" },
                    new Icon { Name = "fa-calendar-minus-o" },
                    new Icon { Name = "fa-calendar-o" },
                    new Icon { Name = "fa-calendar-plus-o" },
                    new Icon { Name = "fa-calendar-times-o" },
                    new Icon { Name = "fa-camera" },
                    new Icon { Name = "fa-camera-retro" },
                    new Icon { Name = "fa-car" },
                    new Icon { Name = "fa-caret-square-o-down" },
                    new Icon { Name = "fa-caret-square-o-left" },
                    new Icon { Name = "fa-caret-square-o-right" },
                    new Icon { Name = "fa-caret-square-o-up" },
                    new Icon { Name = "fa-cart-arrow-down" },
                    new Icon { Name = "fa-cart-plus" },
                    new Icon { Name = "fa-cc" },
                    new Icon { Name = "fa-certificate" },
                    new Icon { Name = "fa-check" },
                    new Icon { Name = "fa-check-circle" },
                    new Icon { Name = "fa-check-circle-o" },
                    new Icon { Name = "fa-check-square" },
                    new Icon { Name = "fa-check-square-o" },
                    new Icon { Name = "fa-child" },
                    new Icon { Name = "fa-circle" },
                    new Icon { Name = "fa-circle-o" },
                    new Icon { Name = "fa-circle-o-notch" },
                    new Icon { Name = "fa-circle-thin" },
                    new Icon { Name = "fa-clock-o" },
                    new Icon { Name = "fa-clone" },
                    new Icon { Name = "fa-close" },
                    new Icon { Name = "fa-cloud" },
                    new Icon { Name = "fa-cloud-download" },
                    new Icon { Name = "fa-cloud-upload" },
                    new Icon { Name = "fa-code" },
                    new Icon { Name = "fa-code-fork" },
                    new Icon { Name = "fa-coffee" },
                    new Icon { Name = "fa-cog" },
                    new Icon { Name = "fa-cogs" },
                    new Icon { Name = "fa-comment" },
                    new Icon { Name = "fa-comment-o" },
                    new Icon { Name = "fa-commenting" },
                    new Icon { Name = "fa-commenting-o" },
                    new Icon { Name = "fa-comments" },
                    new Icon { Name = "fa-comments-o" },
                    new Icon { Name = "fa-compass" },
                    new Icon { Name = "fa-copyright" },
                    new Icon { Name = "fa-creative-commons" },
                    new Icon { Name = "fa-credit-card" },
                    new Icon { Name = "fa-credit-card-alt" },
                    new Icon { Name = "fa-crop" },
                    new Icon { Name = "fa-crosshairs" },
                    new Icon { Name = "fa-cube" },
                    new Icon { Name = "fa-cubes" },
                    new Icon { Name = "fa-cutlery" },
                    new Icon { Name = "fa-dashboard" },
                    new Icon { Name = "fa-database" },
                    new Icon { Name = "fa-desktop" },
                    new Icon { Name = "fa-diamond" },
                    new Icon { Name = "fa-dot-circle-o" },
                    new Icon { Name = "fa-download" },
                    new Icon { Name = "fa-edit" },
                    new Icon { Name = "fa-ellipsis-h" },
                    new Icon { Name = "fa-ellipsis-v" },
                    new Icon { Name = "fa-envelope" },
                    new Icon { Name = "fa-envelope-o" },
                    new Icon { Name = "fa-envelope-square" },
                    new Icon { Name = "fa-eraser" },
                    new Icon { Name = "fa-exchange" },
                    new Icon { Name = "fa-exclamation" },
                    new Icon { Name = "fa-exclamation-circle" },
                    new Icon { Name = "fa-exclamation-triangle" },
                    new Icon { Name = "fa-external-link" },
                    new Icon { Name = "fa-external-link-square" },
                    new Icon { Name = "fa-eye" },
                    new Icon { Name = "fa-eye-slash" },
                    new Icon { Name = "fa-eyedropper" },
                    new Icon { Name = "fa-fax" },
                    new Icon { Name = "fa-feed" },
                    new Icon { Name = "fa-female" },
                    new Icon { Name = "fa-fighter-jet" },
                    new Icon { Name = "fa-file-archive-o" },
                    new Icon { Name = "fa-file-audio-o" },
                    new Icon { Name = "fa-file-code-o" },
                    new Icon { Name = "fa-file-excel-o" },
                    new Icon { Name = "fa-file-image-o" },
                    new Icon { Name = "fa-file-movie-o" },
                    new Icon { Name = "fa-file-pdf-o" },
                    new Icon { Name = "fa-file-photo-o" },
                    new Icon { Name = "fa-file-picture-o" },
                    new Icon { Name = "fa-file-powerpoint-o" },
                    new Icon { Name = "fa-file-sound-o" },
                    new Icon { Name = "fa-file-video-o" },
                    new Icon { Name = "fa-file-word-o" },
                    new Icon { Name = "fa-file-zip-o" },
                    new Icon { Name = "fa-film" },
                    new Icon { Name = "fa-filter" },
                    new Icon { Name = "fa-fire" },
                    new Icon { Name = "fa-fire-extinguisher" },
                    new Icon { Name = "fa-flag" },
                    new Icon { Name = "fa-flag-checkered" },
                    new Icon { Name = "fa-flag-o" },
                    new Icon { Name = "fa-flash" },
                    new Icon { Name = "fa-flask" },
                    new Icon { Name = "fa-folder" },
                    new Icon { Name = "fa-folder-o" },
                    new Icon { Name = "fa-folder-open" },
                    new Icon { Name = "fa-folder-open-o" },
                    new Icon { Name = "fa-frown-o" },
                    new Icon { Name = "fa-futbol-o" },
                    new Icon { Name = "fa-gamepad" },
                    new Icon { Name = "fa-gavel" },
                    new Icon { Name = "fa-gear" },
                    new Icon { Name = "fa-gears" },
                    new Icon { Name = "fa-gift" },
                    new Icon { Name = "fa-glass" },
                    new Icon { Name = "fa-globe" },
                    new Icon { Name = "fa-graduation-cap" },
                    new Icon { Name = "fa-group" },
                    new Icon { Name = "fa-hand-grab-o" },
                    new Icon { Name = "fa-hand-lizard-o" },
                    new Icon { Name = "fa-hand-paper-o" },
                    new Icon { Name = "fa-hand-peace-o" },
                    new Icon { Name = "fa-hand-pointer-o" },
                    new Icon { Name = "fa-hand-rock-o" },
                    new Icon { Name = "fa-hand-scissors-o" },
                    new Icon { Name = "fa-hand-spock-o" },
                    new Icon { Name = "fa-hand-stop-o" },
                    new Icon { Name = "fa-hashtag" },
                    new Icon { Name = "fa-hdd-o" },
                    new Icon { Name = "fa-headphones" },
                    new Icon { Name = "fa-heart" },
                    new Icon { Name = "fa-heart-o" },
                    new Icon { Name = "fa-heartbeat" },
                    new Icon { Name = "fa-history" },
                    new Icon { Name = "fa-home" },
                    new Icon { Name = "fa-hotel" },
                    new Icon { Name = "fa-hourglass" },
                    new Icon { Name = "fa-hourglass-1" },
                    new Icon { Name = "fa-hourglass-2" },
                    new Icon { Name = "fa-hourglass-3" },
                    new Icon { Name = "fa-hourglass-end" },
                    new Icon { Name = "fa-hourglass-half" },
                    new Icon { Name = "fa-hourglass-o" },
                    new Icon { Name = "fa-hourglass-start" },
                    new Icon { Name = "fa-i-cursor" },
                    new Icon { Name = "fa-image" },
                    new Icon { Name = "fa-inbox" },
                    new Icon { Name = "fa-industry" },
                    new Icon { Name = "fa-info" },
                    new Icon { Name = "fa-info-circle" },
                    new Icon { Name = "fa-institution" },
                    new Icon { Name = "fa-key" },
                    new Icon { Name = "fa-keyboard-o" },
                    new Icon { Name = "fa-language" },
                    new Icon { Name = "fa-laptop" },
                    new Icon { Name = "fa-leaf" },
                    new Icon { Name = "fa-legal" },
                    new Icon { Name = "fa-lemon-o" },
                    new Icon { Name = "fa-level-down" },
                    new Icon { Name = "fa-level-up" },
                    new Icon { Name = "fa-life-bouy" },
                    new Icon { Name = "fa-life-buoy" },
                    new Icon { Name = "fa-life-ring" },
                    new Icon { Name = "fa-life-saver" },
                    new Icon { Name = "fa-lightbulb-o" },
                    new Icon { Name = "fa-line-chart" },
                    new Icon { Name = "fa-location-arrow" },
                    new Icon { Name = "fa-lock" },
                    new Icon { Name = "fa-magic" },
                    new Icon { Name = "fa-magnet" },
                    new Icon { Name = "fa-mail-forward" },
                    new Icon { Name = "fa-mail-reply" },
                    new Icon { Name = "fa-mail-reply-all" },
                    new Icon { Name = "fa-male" },
                    new Icon { Name = "fa-map" },
                    new Icon { Name = "fa-map-marker" },
                    new Icon { Name = "fa-map-o" },
                    new Icon { Name = "fa-map-pin" },
                    new Icon { Name = "fa-map-signs" },
                    new Icon { Name = "fa-meh-o" },
                    new Icon { Name = "fa-microphone" },
                    new Icon { Name = "fa-microphone-slash" },
                    new Icon { Name = "fa-minus" },
                    new Icon { Name = "fa-minus-circle" },
                    new Icon { Name = "fa-minus-square" },
                    new Icon { Name = "fa-minus-square-o" },
                    new Icon { Name = "fa-mobile" },
                    new Icon { Name = "fa-mobile-phone" },
                    new Icon { Name = "fa-money" },
                    new Icon { Name = "fa-moon-o" },
                    new Icon { Name = "fa-mortar-board" },
                    new Icon { Name = "fa-motorcycle" },
                    new Icon { Name = "fa-mouse-pointer" },
                    new Icon { Name = "fa-music" },
                    new Icon { Name = "fa-navicon" },
                    new Icon { Name = "fa-newspaper-o" },
                    new Icon { Name = "fa-object-group" },
                    new Icon { Name = "fa-object-ungroup" },
                    new Icon { Name = "fa-paint-brush" },
                    new Icon { Name = "fa-paper-plane" },
                    new Icon { Name = "fa-paper-plane-o" },
                    new Icon { Name = "fa-paw" },
                    new Icon { Name = "fa-pencil" },
                    new Icon { Name = "fa-pencil-square" },
                    new Icon { Name = "fa-pencil-square-o" },
                    new Icon { Name = "fa-percent" },
                    new Icon { Name = "fa-phone" },
                    new Icon { Name = "fa-phone-square" },
                    new Icon { Name = "fa-photo" },
                    new Icon { Name = "fa-picture-o" },
                    new Icon { Name = "fa-pie-chart" },
                    new Icon { Name = "fa-plane" },
                    new Icon { Name = "fa-plug" },
                    new Icon { Name = "fa-plus" },
                    new Icon { Name = "fa-plus-circle" },
                    new Icon { Name = "fa-plus-square" },
                    new Icon { Name = "fa-plus-square-o" },
                    new Icon { Name = "fa-power-off" },
                    new Icon { Name = "fa-print" },
                    new Icon { Name = "fa-puzzle-piece" },
                    new Icon { Name = "fa-qrcode" },
                    new Icon { Name = "fa-question" },
                    new Icon { Name = "fa-question-circle" },
                    new Icon { Name = "fa-quote-left" },
                    new Icon { Name = "fa-quote-right" },
                    new Icon { Name = "fa-random" },
                    new Icon { Name = "fa-recycle" },
                    new Icon { Name = "fa-refresh" },
                    new Icon { Name = "fa-registered" },
                    new Icon { Name = "fa-remove" },
                    new Icon { Name = "fa-reorder" },
                    new Icon { Name = "fa-reply" },
                    new Icon { Name = "fa-reply-all" },
                    new Icon { Name = "fa-retweet" },
                    new Icon { Name = "fa-road" },
                    new Icon { Name = "fa-rocket" },
                    new Icon { Name = "fa-rss" },
                    new Icon { Name = "fa-rss-square" },
                    new Icon { Name = "fa-search" },
                    new Icon { Name = "fa-search-minus" },
                    new Icon { Name = "fa-search-plus" },
                    new Icon { Name = "fa-send" },
                    new Icon { Name = "fa-send-o" },
                    new Icon { Name = "fa-server" },
                    new Icon { Name = "fa-share" },
                    new Icon { Name = "fa-share-alt" },
                    new Icon { Name = "fa-share-alt-square" },
                    new Icon { Name = "fa-share-square" },
                    new Icon { Name = "fa-share-square-o" },
                    new Icon { Name = "fa-shield" },
                    new Icon { Name = "fa-ship" },
                    new Icon { Name = "fa-shopping-bag" },
                    new Icon { Name = "fa-shopping-basket" },
                    new Icon { Name = "fa-shopping-cart" },
                    new Icon { Name = "fa-sign-in" },
                    new Icon { Name = "fa-sign-out" },
                    new Icon { Name = "fa-signal" },
                    new Icon { Name = "fa-sitemap" },
                    new Icon { Name = "fa-sliders" },
                    new Icon { Name = "fa-smile-o" },
                    new Icon { Name = "fa-soccer-ball-o" },
                    new Icon { Name = "fa-sort" },
                    new Icon { Name = "fa-sort-alpha-asc" },
                    new Icon { Name = "fa-sort-alpha-desc" },
                    new Icon { Name = "fa-sort-amount-asc" },
                    new Icon { Name = "fa-sort-amount-desc" },
                    new Icon { Name = "fa-sort-asc" },
                    new Icon { Name = "fa-sort-desc" },
                    new Icon { Name = "fa-sort-down" },
                    new Icon { Name = "fa-sort-numeric-asc" },
                    new Icon { Name = "fa-sort-numeric-desc" },
                    new Icon { Name = "fa-sort-up" },
                    new Icon { Name = "fa-space-shuttle" },
                    new Icon { Name = "fa-spinner" },
                    new Icon { Name = "fa-spoon" },
                    new Icon { Name = "fa-square" },
                    new Icon { Name = "fa-square-o" },
                    new Icon { Name = "fa-star" },
                    new Icon { Name = "fa-star-half" },
                    new Icon { Name = "fa-star-half-empty" },
                    new Icon { Name = "fa-star-half-full" },
                    new Icon { Name = "fa-star-half-o" },
                    new Icon { Name = "fa-star-o" },
                    new Icon { Name = "fa-sticky-note" },
                    new Icon { Name = "fa-sticky-note-o" },
                    new Icon { Name = "fa-street-view" },
                    new Icon { Name = "fa-suitcase" },
                    new Icon { Name = "fa-sun-o" },
                    new Icon { Name = "fa-support" },
                    new Icon { Name = "fa-tablet" },
                    new Icon { Name = "fa-tachometer" },
                    new Icon { Name = "fa-tag" },
                    new Icon { Name = "fa-tags" },
                    new Icon { Name = "fa-tasks" },
                    new Icon { Name = "fa-taxi" },
                    new Icon { Name = "fa-television" },
                    new Icon { Name = "fa-terminal" },
                    new Icon { Name = "fa-thumb-tack" },
                    new Icon { Name = "fa-thumbs-down" },
                    new Icon { Name = "fa-thumbs-o-down" },
                    new Icon { Name = "fa-thumbs-o-up" },
                    new Icon { Name = "fa-thumbs-up" },
                    new Icon { Name = "fa-ticket" },
                    new Icon { Name = "fa-times" },
                    new Icon { Name = "fa-times-circle" },
                    new Icon { Name = "fa-times-circle-o" },
                    new Icon { Name = "fa-tint" },
                    new Icon { Name = "fa-toggle-down" },
                    new Icon { Name = "fa-toggle-left" },
                    new Icon { Name = "fa-toggle-off" },
                    new Icon { Name = "fa-toggle-on" },
                    new Icon { Name = "fa-toggle-right" },
                    new Icon { Name = "fa-toggle-up" },
                    new Icon { Name = "fa-trademark" },
                    new Icon { Name = "fa-trash" },
                    new Icon { Name = "fa-trash-o" },
                    new Icon { Name = "fa-tree" },
                    new Icon { Name = "fa-trophy" },
                    new Icon { Name = "fa-truck" },
                    new Icon { Name = "fa-tty" },
                    new Icon { Name = "fa-tv" },
                    new Icon { Name = "fa-umbrella" },
                    new Icon { Name = "fa-university" },
                    new Icon { Name = "fa-unlock" },
                    new Icon { Name = "fa-unlock-alt" },
                    new Icon { Name = "fa-unsorted" },
                    new Icon { Name = "fa-upload" },
                    new Icon { Name = "fa-user" },
                    new Icon { Name = "fa-user-plus" },
                    new Icon { Name = "fa-user-secret" },
                    new Icon { Name = "fa-user-times" },
                    new Icon { Name = "fa-users" },
                    new Icon { Name = "fa-video-camera" },
                    new Icon { Name = "fa-volume-down" },
                    new Icon { Name = "fa-volume-off" },
                    new Icon { Name = "fa-volume-up" },
                    new Icon { Name = "fa-warning" },
                    new Icon { Name = "fa-wheelchair" },
                    new Icon { Name = "fa-wifi" },
                    new Icon { Name = "fa-wrench" }
                };
                _db.Icons.AddRange(icons);
                _db.SaveChanges();
            }

            #endregion Icons

            if (!_db.FileTypes.Any())
            {
                var types = new List<FileType>
                {
                    new FileType {Name = "txt", Icon = "fa-file-text-o"},
                    new FileType {Name = "ini", Icon = "fa-file-text-o"},
                    new FileType {Name = "doc", Icon = "fa-file-word-o"},
                    new FileType {Name = "docx", Icon = "fa-file-word-o"},
                    new FileType {Name = "zip", Icon = "fa-file-archive-o"},
                    new FileType {Name = "7z", Icon = "fa-file-archive-o"},
                    new FileType {Name = "rar", Icon = "fa-file-archive-o"},
                    new FileType {Name = "tar", Icon = "fa-file-archive-o"},
                    new FileType {Name = "gz", Icon = "fa-file-archive-o"},
                    new FileType {Name = "iso", Icon = "fa-file-archive-o"},
                    new FileType {Name = "bin", Icon = "fa-file-archive-o"},
                    new FileType {Name = "cs", Icon = "fa-file-code-o"},
                    new FileType {Name = "java", Icon = "fa-file-code-o"},
                    new FileType {Name = "py", Icon = "fa-file-code-o"},
                    new FileType {Name = "c", Icon = "fa-file-code-o"},
                    new FileType {Name = "cpp", Icon = "fa-file-code-o"},
                    new FileType {Name = "html", Icon = "fa-file-code-o"},
                    new FileType {Name = "css", Icon = "fa-file-code-o"},
                    new FileType {Name = "js", Icon = "fa-file-code-o"},
                    new FileType {Name = "jpg", Icon = "fa-file-image-o"},
                    new FileType {Name = "png", Icon = "fa-file-image-o"},
                    new FileType {Name = "ico", Icon = "fa-file-image-o"},
                    new FileType {Name = "jpeg", Icon = "fa-file-image-o"},
                    new FileType {Name = "gif", Icon = "fa-file-image-o"},
                    new FileType {Name = "tif", Icon = "fa-file-image-o"},
                    new FileType {Name = "pdf", Icon = "fa-file-pdf-o"},
                    new FileType {Name = "avi", Icon = "fa-file-video-o"},
                    new FileType {Name = "mpg", Icon = "fa-file-video-o"},
                    new FileType {Name = "mpeg", Icon = "fa-file-video-o"},
                    new FileType {Name = "mkv", Icon = "fa-file-video-o"},
                    new FileType {Name = "mp4", Icon = "fa-file-video-o"},
                    new FileType {Name = "flv", Icon = "fa-file-video-o"},
                    new FileType {Name = "3gp", Icon = "fa-file-video-o"},
                    new FileType {Name = "wmv", Icon = "fa-file-video-o"},
                    new FileType {Name = "ppt", Icon = "fa-file-powerpoint-o"},
                    new FileType {Name = "pptx", Icon = "fa-file-powerpoint-o"},
                    new FileType {Name = "mp3", Icon = "fa-file-audio-o"},
                    new FileType {Name = "m4a", Icon = "fa-file-audio-o"},
                    new FileType {Name = "wmv", Icon = "fa-file-audio-o"},
                    new FileType {Name = "flac", Icon = "fa-file-audio-o"},
                    new FileType {Name = "xls", Icon = "fa-excel-o"},
                    new FileType {Name = "xlsx", Icon = "fa-excel-o"}
                };
                _db.FileTypes.AddRange(types);
                _db.SaveChanges();
            }

            if (!_db.Sections.Any())
            {
                var sections = new List<Section>
                {
                    new Section { Name = "Navigation"},
                    new Section { Name = "Header Top"},
                    new Section { Name = "Header Bottom"},
                    new Section { Name = "Breadcrumb"},
                    new Section { Name = "Main Top"},
                    new Section { Name = "Main Middle"},
                    new Section { Name = "Main Bottom"},
                    new Section { Name = "Left sidebar"},
                    new Section { Name = "Right sidebar"},
                    new Section { Name = "Footer Top"},
                    new Section { Name = "Footer Bottom"},
                };
                _db.Sections.AddRange(sections);
                _db.SaveChanges();
            }

            if (!_db.Menus.Any())
            {
                _db.Menus.Add(new Menu
                {
                    Name = "Main",
                    SectionId = _db.Sections.FirstOrDefault(x => x.Name == "Navigation").Id
                });
                _db.SaveChanges();
            }

            if (_db.Collections.FirstOrDefault(x => x.Name == "Hello Collection") == null)
            {
                _db.Collections.Add(new Collection
                {
                    Name = "Hello Collection",
                    CollectionType = "Big Icon"
                });
                _db.SaveChanges();
            }

            if (!_db.CollectionItems.Any())
            {
                var serviceItems = new List<CollectionItem>
                {
                    new CollectionItem
                    {
                        Name = "First item",
                        Synopsis = "This is first service item.",
                        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore" +
                               " et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut " +
                               "aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum " +
                               "dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui " +
                               "officia deserunt mollit anim id est laborum.",
                        Title = "First item title",
                        Hyperlink = "#",
                        Icon = "fa-mixcloud",
                        CollectionId = _db.Collections.FirstOrDefault(x => x.Name == "Hello Collection").Id
                    },
                    new CollectionItem
                    {
                        Name = "Second item",
                        Synopsis = "This is second <b>service</b> item.",
                        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore" +
                               " et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut " +
                               "aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum " +
                               "dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui " +
                               "officia deserunt mollit anim id est laborum.",
                        Title = "First item title",
                        Hyperlink = "#",
                        Icon = "fa-archive",
                        CollectionId = _db.Collections.FirstOrDefault(x => x.Name == "Hello Collection").Id
        },
                    new CollectionItem
                    {
                        Name = "Third item",
                        Synopsis = "This is <i>third</i> service item.",
                        Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore" +
                               " et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut " +
                               "aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum " +
                               "dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui " +
                               "officia deserunt mollit anim id est laborum.",
                        Title = "First item title",
                        Hyperlink = "#",
                        Icon = "fa-bank",
                        CollectionId = _db.Collections.FirstOrDefault(x => x.Name == "Hello Collection").Id
                    }
                };
                _db.CollectionItems.AddRange(serviceItems);
                _db.SaveChanges();
            }
        }
    }
}