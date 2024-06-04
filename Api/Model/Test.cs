
using System.Security.Cryptography.Xml;

public class Test
{
    public Data data { get; set; }
}

public class Data
{
    public About about { get; set; }
    public object[] account_badges { get; set; }
    public int account_type { get; set; }
    public Active_Standalone_Fundraisers active_standalone_fundraisers { get; set; }
    public object ads_incentive_expiration_date { get; set; }
    public object ads_page_id { get; set; }
    public object ads_page_name { get; set; }
    public Bio_Links[] bio_links { get; set; }
    public string biography { get; set; }
    public object biography_email { get; set; }
    public Biography_With_Entities biography_with_entities { get; set; }
    public string business_contact_method { get; set; }
    public bool can_add_fb_group_link_on_profile { get; set; }
    public bool can_hide_category { get; set; }
    public bool can_hide_public_contacts { get; set; }
    public string category { get; set; }
    public long category_id { get; set; }
    public string contact_phone_number { get; set; }
    public object current_catalog_id { get; set; }
    public string direct_messaging { get; set; }
    public string external_lynx_url { get; set; }
    public string external_url { get; set; }
    public string fbid_v2 { get; set; }
    public int follower_count { get; set; }
    public int following_count { get; set; }
    public string full_name { get; set; }
    public bool has_anonymous_profile_picture { get; set; }
    public bool has_chaining { get; set; }
    public bool has_guides { get; set; }
    public bool has_igtv_series { get; set; }
    public Hd_Profile_Pic_Url_Info hd_profile_pic_url_info { get; set; }
    public Hd_Profile_Pic_Versions[] hd_profile_pic_versions { get; set; }
    public string id { get; set; }
    public bool is_business { get; set; }
    public bool? is_call_to_action_enabled { get; set; }
    public bool is_category_tappable { get; set; }
    public bool is_eligible_for_request_message { get; set; }
    public bool is_favorite { get; set; }
    public bool is_favorite_for_clips { get; set; }
    public bool is_favorite_for_igtv { get; set; }
    public bool is_favorite_for_stories { get; set; }
    public bool is_private { get; set; }
    public bool is_profile_audio_call_enabled { get; set; }
    public bool is_verified { get; set; }
    public int latest_reel_media { get; set; }
    public string live_subscription_status { get; set; }
    public Location_Data location_data { get; set; }
    public int media_count { get; set; }
    public string merchant_checkout_style { get; set; }
    public object page_id { get; set; }
    public object page_name { get; set; }
    public Pinned_Channels_Info pinned_channels_info { get; set; }
    public int primary_profile_link_type { get; set; }
    public int professional_conversion_suggested_account_type { get; set; }
    public string profile_context { get; set; }
    public object[] profile_context_facepile_users { get; set; }
    public object[] profile_context_links_with_user_ids { get; set; }
    public string profile_pic_id { get; set; }
    public string profile_pic_url { get; set; }
    public string profile_pic_url_hd { get; set; }
    public string public_email { get; set; }
    public string public_phone_country_code { get; set; }
    public string public_phone_number { get; set; }
    public string seller_shoppable_feed_type { get; set; }
    public bool show_shoppable_feed { get; set; }
    public int third_party_downloads_enabled { get; set; }
    public int total_igtv_videos { get; set; }
    public object[] upcoming_events { get; set; }
    public string username { get; set; }
}

public class About
{
    public string country { get; set; }
    public string date_joined { get; set; }
    public int date_joined_as_timestamp { get; set; }
    public int former_usernames { get; set; }
}

public class Active_Standalone_Fundraisers
{
    public object[] fundraisers { get; set; }
    public int total_count { get; set; }
}

public class Biography_With_Entities
{
    public Entity[] entities { get; set; }
    public string raw_text { get; set; }
}

public class Entity
{
    public User user { get; set; }
}

public class User
{
    public long id { get; set; }
    public string username { get; set; }
}

public class Hd_Profile_Pic_Url_Info
{
    public int height { get; set; }
    public string url { get; set; }
    public int width { get; set; }
}

public class Location_Data
{
    public string address_street { get; set; }
    public object city_id { get; set; }
    public string city_name { get; set; }
    public string instagram_location_id { get; set; }
    public object latitude { get; set; }
    public object longitude { get; set; }
    public string zip { get; set; }
}

public class Pinned_Channels_Info
{
    public bool has_public_channels { get; set; }
    public object[] pinned_channels_list { get; set; }
}

public class Bio_Links
{
    public bool is_pinned { get; set; }
    public long link_id { get; set; }
    public string link_type { get; set; }
    public string lynx_url { get; set; }
    public bool open_external_url_with_in_app_browser { get; set; }
    public string title { get; set; }
    public string url { get; set; }
}

public class Hd_Profile_Pic_Versions
{
    public int height { get; set; }
    public string url { get; set; }
    public int width { get; set; }
}
